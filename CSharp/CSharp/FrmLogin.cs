using CSharp.Entity;
using CSharp.Helper;
using CSharp.Service;
using Newtonsoft.Json.Linq;

namespace CSharp
{
    public partial class FrmLogin : Form
    {
        private string token = "";
        private string password = "";
        PostService http = new PostService();
        public FrmLogin()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.init();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
        }

        public string getToken()
        {
            return token;
        }

        public string getPassword()
        {
            return password;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UtilService.openUlr("https://github.com/abigsoft/ChildrenOnline");
        }

        private void init()
        {
            IniHelper.Instance.FileName = "conf/config.ini";
            textBox1.Text = IniHelper.Instance.ReadString("Account", "Account", "");
            textBox2.Text = IniHelper.Instance.ReadString("Account", "Password", "");
        }



        public void doClose(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 0)
            {
                this.tabControl1.SelectedIndex = 1;
                return;
            }
            if (this.tabControl1.SelectedIndex == 1)
            {
                this.tabControl1.SelectedIndex = 0;
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            doLogin();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            doRegister();
        }
        private void doLogin()
        {
            String account = textBox1.Text;
            String password = textBox2.Text;
            if (account == "" || password == "")
            {
                MessageBox.Show("账号密码不能为空");
                return;
            }

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("account", account);
            dic.Add("password", password);
            ResultEntity result = http.apiPost("login/account", dic);

            if (result.getStatus() != 200)
            {
                MessageBox.Show(result.getMsg());
                return;
            }
            IniHelper.Instance.WriteString("Account", "Account", account);
            IniHelper.Instance.WriteString("Account", "Password", password);

            this.token = JTokenHelper.ToStr(result.getData());
            this.password = password;
            this.Close();
        }

        private void doRegister()
        {
            String account = textBox3.Text;
            String password = textBox4.Text;
            String name = textBox5.Text;
            int sex = radioButton1.Checked ? 1 : 2;
            if (account == "" || password == "" || name == "")
            {
                MessageBox.Show("请将表单填写完毕");
                return;
            }

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("account", account);
            dic.Add("password", password);
            dic.Add("nickname", name);
            dic.Add("sex", sex.ToString());
            dic.Add("nature", comboBox1.SelectedIndex.ToString());
            ResultEntity result = http.apiPost("register/account", dic);
            MessageBox.Show(result.getMsg());
            if (result.getStatus() != 200)
            {
                return;
            }
            textBox1.Text = account;
            textBox2.Text = password;
            tabControl1.SelectedIndex = 0;
        }

    }
}