using fNbt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPTool
{
    public partial class Form1 : Form
    {
        string filePath= "C:\\Users\\bryan\\AppData\\Roaming\\.minecraft\\saves\\Final_Paradox_v1.0.7\\data\\scoreboard.dat";
        public Form1()
        {
            InitializeComponent();
            test(filePath);
        }
        void test(string Path)
        {
            NbtFile file = new NbtFile(Path);
            var root = file.RootTag;
            var RootTags = (NbtCompound)root.Tags.ToList()[0];
            var dataIndex = RootTags.Names.ToList().IndexOf("Objectives");
            var data = (NbtList)RootTags.Tags.ToList()[dataIndex];

        }
        
    }
}
