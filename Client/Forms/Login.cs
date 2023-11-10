using Client.Classes;

namespace Client.Forms
{
    internal partial class Login : Form
    {
        private FormManager formManager;

        public Login(FormManager inManager)
        {
            InitializeComponent();
            formManager = inManager;
        }
    }
}
