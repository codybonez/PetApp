using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace PetApp
{
    public partial class MeetupForm : Form
    {
        static HttpClient client = new HttpClient();
        const string api_key = "?api-key=foo";
        Image petImage;
        Pet pet = new Pet();
        public MeetupForm()
        {
            pet.Load(pet);
            
            InitializeComponent();
            client.BaseAddress = new Uri("https://virtualpetparty.up.railway.app");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            this.petImage = Properties.Resources.AngryDog;
            this.pictureBox2.Image = Properties.Resources.SadDog;


        }

        private void MeetupForm_Load(object sender, EventArgs e)
        {

        }

   

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private async void Btn_CreateRoom_Click(object sender, EventArgs e)
        {
            byte[] bytes;
            using (var ms = new MemoryStream())
            {
                this.petImage.Save(ms, this.petImage.RawFormat);
                bytes = ms.ToArray();
            }

            var d = new {name = pet.Name  , image = Convert.ToBase64String(bytes) };

            

            HttpResponseMessage response = await client.PostAsJsonAsync(
                "/api/room/create" + api_key, d);


            response.EnsureSuccessStatusCode();

            var s = await response.Content.ReadAsStringAsync();
            s = s.Trim('"');
           
            txt_code.Text = s;

        }
        private async void Btn_JoinRoom_Click(object sender, EventArgs e)
        {
            var roomid = txt_code.Text;
            var d = new { };

            HttpResponseMessage response = await client.PostAsJsonAsync(
                "/api/room/join/" + roomid + api_key, d);

            response.EnsureSuccessStatusCode();

            var s = await response.Content.ReadAsStringAsync();

            var r = JsonSerializer.Deserialize<Room>(s);
          

            Byte[] bitmapData = Convert.FromBase64String(r.visitor.image);
            MemoryStream streamBitmap = new MemoryStream(bitmapData);
            Bitmap b = new Bitmap((Bitmap)Image.FromStream(streamBitmap));

            pictureBox1.Image = b;
            lbl_petName.Text = r.visitor.name;
            label2.Text = pet.Name;
            
        }
        public class Room
        {
            public ShortPet visitor { get; set; }
        }
        public class ShortPet
        {
            public string name { get; set; }
            public string image { get; set; }
        }
    }
}
