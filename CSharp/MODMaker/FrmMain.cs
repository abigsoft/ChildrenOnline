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

            // 列出mod目录下所有的文件夹
            if (Directory.Exists(modDirectory))
            {
                string[] folders = Directory.GetDirectories(modDirectory);
                foreach (var folder in folders)
                {
                    string folderName = Path.GetFileName(folder);
                    folderNames.Add("mod/" + folderName);
                    // 找到对应的character.json文件
                    string jsonFilePath = Path.Combine(folder, "character.json");
                    if (File.Exists(jsonFilePath))
                    {
                        // 读取JSON文件并反序列化为Character类的对象
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
            // 此处可根据需要对characters列表进行操作
            // 例如：打印每个Character的Thumb属性
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
            MessageBox.Show("刷新完成");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            if (index >= characters.Count || index >= folderNames.Count)
            {
                MessageBox.Show("数据异常，请刷新后重试");
                return;
            }
            select_character = characters[index];
            select_mod_path = folderNames[index];

            if (string.IsNullOrEmpty(select_character.Thumb) || !File.Exists(Path.Combine(select_mod_path, select_character.Thumb)))
            {
                pictureBox1.Image = Properties.Resources.没有图片;
            }
            else
            {
                pictureBox1.Load(select_character.Thumb);
            }
            textBox1.Text = select_character.Desc;
            label3.Text = "当前选择模型：【" + select_mod_path + "】" + select_character.Desc;
            MessageBox.Show("加载完成");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(select_character, Formatting.Indented);
            string jsonFilePath = Path.Combine(select_mod_path, "character.json");
            File.WriteAllText(jsonFilePath, json);
            MessageBox.Show("保存成功");
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if(e.RowIndex == dataGridView1.Rows.Count - 1)
            {
                return;
            }
            // 使用 RowIndex 属性获取当前行的索引，并将其转换为字符串
            string rowIndex = (e.RowIndex + 1).ToString();

            // 获取 DataGridView 的字体
            System.Drawing.Font rowFont = dataGridView1.RowHeadersDefaultCellStyle.Font;

            // 如果未设置字体，则使用默认字体
            if (rowFont == null)
            {
                rowFont = dataGridView1.DefaultCellStyle.Font;
            }

            // 计算显示行号的位置
            System.Drawing.Point headerBounds = new System.Drawing.Point(e.RowBounds.Left, e.RowBounds.Top);
            System.Drawing.Size textSize = TextRenderer.MeasureText(rowIndex, rowFont);
            System.Drawing.Point textLocation = new System.Drawing.Point(
                headerBounds.X + (dataGridView1.RowHeadersWidth - textSize.Width) / 2,
                headerBounds.Y + (e.RowBounds.Height - textSize.Height) / 2);

            // 绘制行号
            e.Graphics.DrawString(rowIndex, rowFont, SystemBrushes.ControlText, textLocation);
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex == dataGridView2.Rows.Count - 1)
            {
                return;
            }
            // 使用 RowIndex 属性获取当前行的索引，并将其转换为字符串
            string rowIndex = (e.RowIndex + 1).ToString();

            // 获取 DataGridView 的字体
            System.Drawing.Font rowFont = dataGridView2.RowHeadersDefaultCellStyle.Font;

            // 如果未设置字体，则使用默认字体
            if (rowFont == null)
            {
                rowFont = dataGridView2.DefaultCellStyle.Font;
            }

            // 计算显示行号的位置
            System.Drawing.Point headerBounds = new System.Drawing.Point(e.RowBounds.Left, e.RowBounds.Top);
            System.Drawing.Size textSize = TextRenderer.MeasureText(rowIndex, rowFont);
            System.Drawing.Point textLocation = new System.Drawing.Point(
                headerBounds.X + (dataGridView2.RowHeadersWidth - textSize.Width) / 2,
                headerBounds.Y + (e.RowBounds.Height - textSize.Height) / 2);

            // 绘制行号
            e.Graphics.DrawString(rowIndex, rowFont, SystemBrushes.ControlText, textLocation);
        }
    }
}