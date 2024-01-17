using MODMaker.Entity;
using Newtonsoft.Json;

namespace MODMaker
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.refresh();
        }
        List<Character> characters = new List<Character>();
        List<string> folderNames = new List<string>();
        Character select_character = new Character();
        string select_mod_path = "";
        private void refresh()
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string modDirectory = Path.Combine(appDirectory, "mod");
            folderNames = new List<string>();
            characters = new List<Character>();

            // �г�modĿ¼�����е��ļ���
            if (Directory.Exists(modDirectory))
            {
                string[] folders = Directory.GetDirectories(modDirectory);
                foreach (var folder in folders)
                {
                    string folderName = Path.GetFileName(folder);
                    folderNames.Add("mod/" + folderName);
                    // �ҵ���Ӧ��character.json�ļ�
                    string jsonFilePath = Path.Combine(folder, "character.json");
                    if (File.Exists(jsonFilePath))
                    {
                        // ��ȡJSON�ļ��������л�ΪCharacter��Ķ���
                        string jsonData = File.ReadAllText(jsonFilePath);
                        if (jsonData != null)
                        {
                            Character character = JsonConvert.DeserializeObject<Character>(jsonData);
                            if (character != null)
                            {
                                characters.Add(character);
                            }
                        }

                    }
                }
            }
            comboBox1.Items.Clear();
            // �˴��ɸ�����Ҫ��characters�б���в���
            // ���磺��ӡÿ��Character��Thumb����
            foreach (var character in characters)
            {
                comboBox1.Items.Add(character.Desc);
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.refresh();
            MessageBox.Show("ˢ�����");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index >= characters.Count || index >= folderNames.Count)
            {
                MessageBox.Show("�����쳣����ˢ�º�����");
                return;
            }
            select_character = characters[index];
            select_mod_path = folderNames[index];

            if (string.IsNullOrEmpty(select_character.Thumb) || !File.Exists(Path.Combine(select_mod_path, select_character.Thumb)))
            {
                pictureBox1.Image = Properties.Resources.û��ͼƬ;
            }
            else
            {
                pictureBox1.Load(select_character.Thumb);
            }
            textBox1.Text = select_character.Desc;
            label3.Text = "��ǰѡ��ģ�ͣ���" + select_mod_path + "��" + select_character.Desc;
            MessageBox.Show("�������");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(select_character, Formatting.Indented);
            string jsonFilePath = Path.Combine(select_mod_path, "character.json");
            File.WriteAllText(jsonFilePath, json);
            MessageBox.Show("����ɹ�");
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if(e.RowIndex == dataGridView1.Rows.Count - 1)
            {
                return;
            }
            // ʹ�� RowIndex ���Ի�ȡ��ǰ�е�������������ת��Ϊ�ַ���
            string rowIndex = (e.RowIndex + 1).ToString();

            // ��ȡ DataGridView ������
            System.Drawing.Font rowFont = dataGridView1.RowHeadersDefaultCellStyle.Font;

            // ���δ�������壬��ʹ��Ĭ������
            if (rowFont == null)
            {
                rowFont = dataGridView1.DefaultCellStyle.Font;
            }

            // ������ʾ�кŵ�λ��
            System.Drawing.Point headerBounds = new System.Drawing.Point(e.RowBounds.Left, e.RowBounds.Top);
            System.Drawing.Size textSize = TextRenderer.MeasureText(rowIndex, rowFont);
            System.Drawing.Point textLocation = new System.Drawing.Point(
                headerBounds.X + (dataGridView1.RowHeadersWidth - textSize.Width) / 2,
                headerBounds.Y + (e.RowBounds.Height - textSize.Height) / 2);

            // �����к�
            e.Graphics.DrawString(rowIndex, rowFont, SystemBrushes.ControlText, textLocation);
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex == dataGridView2.Rows.Count - 1)
            {
                return;
            }
            // ʹ�� RowIndex ���Ի�ȡ��ǰ�е�������������ת��Ϊ�ַ���
            string rowIndex = (e.RowIndex + 1).ToString();

            // ��ȡ DataGridView ������
            System.Drawing.Font rowFont = dataGridView2.RowHeadersDefaultCellStyle.Font;

            // ���δ�������壬��ʹ��Ĭ������
            if (rowFont == null)
            {
                rowFont = dataGridView2.DefaultCellStyle.Font;
            }

            // ������ʾ�кŵ�λ��
            System.Drawing.Point headerBounds = new System.Drawing.Point(e.RowBounds.Left, e.RowBounds.Top);
            System.Drawing.Size textSize = TextRenderer.MeasureText(rowIndex, rowFont);
            System.Drawing.Point textLocation = new System.Drawing.Point(
                headerBounds.X + (dataGridView2.RowHeadersWidth - textSize.Width) / 2,
                headerBounds.Y + (e.RowBounds.Height - textSize.Height) / 2);

            // �����к�
            e.Graphics.DrawString(rowIndex, rowFont, SystemBrushes.ControlText, textLocation);
        }
    }
}