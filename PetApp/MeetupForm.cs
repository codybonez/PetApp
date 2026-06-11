using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetApp
{
    public partial class MeetupForm : Form
    {
        static HttpClient client = new HttpClient();
        const string api_key = "?api-key=foo";
        Image petImage;
        public MeetupForm()
        {

            InitializeComponent();
            client.BaseAddress = new Uri("https://virtualpetparty.up.railway.app");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            this.petImage = Properties.Resources.HappyDog;
            this.pictureBox2.Image = Properties.Resources.SadDog;

        }

        private void MeetupForm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_CreateRoom_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
