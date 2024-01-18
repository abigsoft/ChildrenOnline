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
        State select_state = new State();
        string select_mod_path = "";
        private void refresh()
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string modDirectory = Path.Combine(appDirectory, "mod");
            folderNames = new List<string>();
            characters = new List<Character>();
            select_state = new State();
            // �г�modĿ¼�����е��ļ���
            if (Directory.Exists(modDirectory))
            {
                string[] folders = Directory.GetDirectories(modDirectory);
                foreach (var folder in folders)
                {
                    string folderName = Path.GetFileName(folder);
                    folderNames.Add(folderName);
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
                comboBox1.Items.Add(character.Desc == null ? "" : character.Desc);
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

            if (string.IsNullOrEmpty(select_character.Thumb) || !File.Exists(Path.Combine("mod", select_mod_path, select_character.Thumb)))
            {
                pictureBox1.Image = Properties.Resources.û��ͼƬ;
            }
            else
            {
                pictureBox1.Load(select_character.Thumb);
            }
            textBox1.Text = select_character.Desc == null ? "" : select_character.Desc;
            label3.Text = "��ǰѡ��ģ�ͣ���" + select_mod_path + "��" + select_character.Desc;
            foreach (State state in select_character.State)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow newRow = dataGridView1.Rows[rowIndex];

                newRow.Cells[0].Value = state.Name;
                //newRow.Cells[1].Value = state.Play;
                newRow.Cells[1].Value = ((DataGridViewComboBoxColumn)dataGridView1.Columns[1]).Items[state.Play];
                newRow.Cells[2].Value = ((DataGridViewComboBoxColumn)dataGridView1.Columns[2]).Items[state.Position];
                //newRow.Cells[2].Value = state.Position;
                newRow.Cells[3].Value = state.Mood.min + " - " + state.Mood.max;
                newRow.Cells[4].Value = state.Physical.min + " - " + state.Physical.max;

            }


            MessageBox.Show("�������");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�����У��ݲ�����");
            return;
            select_character.Desc = textBox1.Text;
            string json = JsonConvert.SerializeObject(select_character, Formatting.Indented);
            string jsonFilePath = Path.Combine("mod", select_mod_path, "character.json");
            File.WriteAllText(jsonFilePath, json);
            MessageBox.Show("����ɹ�");
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex == dataGridView1.Rows.Count - 1)
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

        private void button4_Click(object sender, EventArgs e)
        {
            FrmUI.FrmInput frm = new FrmUI.FrmInput();
            frm.setTitle("������Ŀ¼��");
            frm.setLabel("������Ŀ¼��");
            frm.setPlaceholder("�벻Ҫ��������");
            frm.ShowDialog();
            if (frm.status && !string.IsNullOrEmpty(frm.getInput()))
            {
                if (Directory.Exists("mod/" + frm.getInput()))
                {
                    MessageBox.Show("Ŀ¼�Ѵ���");
                    return;
                }
                Directory.CreateDirectory("mod/" + frm.getInput());
                this.refresh();
                string json = JsonConvert.SerializeObject(new Character()
                {
                    Desc = frm.getInput(),
                    Thumb = "",
                    State = new List<State>(),
                }, Formatting.Indented); ;
                string jsonFilePath = Path.Combine("mod/" + frm.getInput(), "character.json");
                File.WriteAllText(jsonFilePath, json);
                MessageBox.Show("Ŀ¼�����ɹ�");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (select_mod_path == "")
            {
                MessageBox.Show("����ѡ��ģ��");
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), "mod", select_mod_path);
            openFileDialog.Filter = "ѡ�� PNG ��ʽͼƬ (*.png)|*.png"; // ֻ����ѡ�� PNG ͼƬ
            openFileDialog.RestoreDirectory = true; // �ڹرնԻ����ԭ֮ǰ��Ŀ¼
            openFileDialog.CheckFileExists = true; // ����ļ��Ƿ����
            openFileDialog.CheckPathExists = true; // ���·���Ƿ����

            // ����Ϊtrue�Խ�ֹ������λ�ñ��桱�����Ϊ���Ի����еġ����������
            // �ⲻ����ȫ��ֹ����Ŀ¼�������������ƴ򿪻����Ϊ�Ի����ĳЩ����
            openFileDialog.DereferenceLinks = false; // ����򿪿�ݷ�ʽ��ָ��Ŀ¼

            // �򿪶Ի��򲢼���Ƿ�ѡ�����ļ�
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // ��ȡѡ����ļ�·��
                string selectedFileName = openFileDialog.FileName;
                pictureBox1.Load(selectedFileName);
                select_character.Thumb = selectedFileName;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}