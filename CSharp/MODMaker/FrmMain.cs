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
            // 列出mod目录下所有的文件夹
            if (Directory.Exists(modDirectory))
            {
                string[] folders = Directory.GetDirectories(modDirectory);
                foreach (var folder in folders)
                {
                    string folderName = Path.GetFileName(folder);
                    folderNames.Add(folderName);
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

            if (string.IsNullOrEmpty(select_character.Thumb) || !File.Exists(Path.Combine("mod", select_mod_path, select_character.Thumb)))
            {
                pictureBox1.Image = Properties.Resources.没有图片;
            }
            else
            {
                pictureBox1.Load(select_character.Thumb);
            }
            textBox1.Text = select_character.Desc == null ? "" : select_character.Desc;
            label3.Text = "当前选择模型：【" + select_mod_path + "】" + select_character.Desc;
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


            MessageBox.Show("加载完成");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("开发中，暂不开放");
            return;
            select_character.Desc = textBox1.Text;
            string json = JsonConvert.SerializeObject(select_character, Formatting.Indented);
            string jsonFilePath = Path.Combine("mod", select_mod_path, "character.json");
            File.WriteAllText(jsonFilePath, json);
            MessageBox.Show("保存成功");
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex == dataGridView1.Rows.Count - 1)
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

        private void button4_Click(object sender, EventArgs e)
        {
            FrmUI.FrmInput frm = new FrmUI.FrmInput();
            frm.setTitle("请输入目录名");
            frm.setLabel("请输入目录名");
            frm.setPlaceholder("请不要输入中文");
            frm.ShowDialog();
            if (frm.status && !string.IsNullOrEmpty(frm.getInput()))
            {
                if (Directory.Exists("mod/" + frm.getInput()))
                {
                    MessageBox.Show("目录已存在");
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
                MessageBox.Show("目录创建成功");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (select_mod_path == "")
            {
                MessageBox.Show("请先选择模型");
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), "mod", select_mod_path);
            openFileDialog.Filter = "选择 PNG 格式图片 (*.png)|*.png"; // 只允许选择 PNG 图片
            openFileDialog.RestoreDirectory = true; // 在关闭对话框后还原之前的目录
            openFileDialog.CheckFileExists = true; // 检查文件是否存在
            openFileDialog.CheckPathExists = true; // 检查路径是否存在

            // 设置为true以禁止“在新位置保存”或“另存为”对话框中的“浏览”功能
            // 这不会完全禁止更改目录，但是它会限制打开或另存为对话框的某些功能
            openFileDialog.DereferenceLinks = false; // 避免打开快捷方式所指的目录

            // 打开对话框并检查是否选中了文件
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取选择的文件路径
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