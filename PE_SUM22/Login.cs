using Services.Services;

namespace PE_SUM22
{
    public partial class Login : Form
    {
        UserSession session = new UserSession();
        UserServices _userService;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Management management = new Management();
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            _userService = new UserServices();
            var account = _userService.GetAll().Where(p => p.UserName.Equals(userName)
                                      && p.Password.Equals(password))
                                      .FirstOrDefault();
            if (account != null)
            {
                MessageBox.Show("Login success", "Notification", MessageBoxButtons.OK);
                this.Hide();
                management.Show();
                UserSession.Instance.Username = userName;
                 UserSession.Instance.Role= account.UserRole.ToString();
            }
            else MessageBox.Show("Login false", "Notification", MessageBoxButtons.OK);

        }
    }
}