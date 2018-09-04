using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap10Tutorials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowAnimalInfo (Animal animal)
        {
            MessageBox.Show("Species " + animal.Species);
            animal.MakeSound();
        }

        private void createAnimalBtn_Click(object sender, EventArgs e)
        {
            Animal myAnimal = new Animal("Regular Animal");
            ShowAnimalInfo(myAnimal);
        }

        private void createDogBtn_Click(object sender, EventArgs e)
        {
            Dog myDog = new Dog("Fursona");
            MessageBox.Show("The dog's name is " + myDog.Name);
            ShowAnimalInfo(myDog);
        }

        private void createCatBtn_Click(object sender, EventArgs e)
        {
            Cat myCat = new Cat("Meowth");
            MessageBox.Show("The cat's name is " + myCat.Name);
            ShowAnimalInfo(myCat);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
