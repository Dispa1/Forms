using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;
namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        List<string> price;
        private string[] a;

        public object Massege { get; private set; }

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "300,000 Тенге" });
            comboBox1.Items.AddRange(new string[] { "750,000 Тенге" });
            comboBox1.Items.AddRange(new string[] { "1,500,000 Тенге" });
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            price = new List<string>()
            {
                "Стол в фермерском стиле","Комплект стульев(4шт) в фермерском стиле","холодильник в фермерском стиле","Посудомоечная машина в фермерском стиле","Кухонный гарнитур в фермерском стиле","Микроволновка в фермерском стиле","Духовая печь в фермерском стиле","Вытижка в фермерском стиле","Электрическая плита в фермерском стиле",
                  "Стол в современном стиле","Комплект стульев(4шт) в современном стиле","холодильник в современном стиле","Посудомоечная машина в современном стиле","Кухонный гарнитур в современном стиле","Микроволновка в современном стиле","Духовая печь в современном стиле","Вытижка в современном стиле","Электрическая плита в современном стиле",
                   "Стол в коттеджном стиле","Комплект стульев(4шт) в коттеджном стиле","холодильник в коттеджном стиле","Посудомоечная машина в коттеджном стиле","Кухонный гарнитур в коттеджном стиле","Микроволновка в коттеджном стиле","Духовая печь в коттеджном стиле","Вытижка в коттеджном стиле","Электрическая плита в коттеджном стиле"
            };

            
            price.Sort();
            for (int i = 0; i < price.Count; i++)
            {
                listBox1.Items.Add(price[i]);
            }
           
        }
       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.Text)
            {
                case "300,000 Тенге":
                    DialogResult result = MessageBox.Show(                       
                        "Стол в фермерском стиле, "
                        + "\nКомплект стульев(4шт) в фермерском стиле, " +
                        "\nхолодильник в фермерском стиле, " +
                        "\nПосудомоечная машина в фермерском стиле, " +
                        "\nКухонный гарнитур в фермерском стиле, " +
                        "\nМикроволновка в фермерском стиле, " +
                        "\nДуховая печь в фермерском стиле, " +
                        "\nВытижка в фермерском стиле, " +
                        "\nЭлектрическая плита в фермерском стиле", 
                        "\nВас устраивает этот список?",                       
                        MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                        listBox1.BackColor = Color.Green;
                    if (result == DialogResult.No)
                        listBox1.BackColor = Color.Red;
                    this.TopMost = true;
                    break;
                case "750,000 Тенге":
                    DialogResult result1 = MessageBox.Show(
                        "Стол в современном стиле, " +
                        "\nКомплект стульев(4шт) в современном стиле, " +
                        "\nхолодильник в современном стиле, " +
                        "\nПосудомоечная машина в современном стиле, " +
                        "\nКухонный гарнитур в современном стиле, " +
                        "\nМикроволновка в современном стиле, " +
                        "\nДуховая печь в современном стиле, " +
                        "\nВытижка в современном стиле, " +
                        "\nЭлектрическая плита в современном стиле", 
                        "\nВас устраивает этот список?",
                        MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                        listBox1.BackColor = Color.Green;
                    if (result1 == DialogResult.No)
                        listBox1.BackColor = Color.Red;
                    break;
                case "1,500,000 Тенге":
                    DialogResult result2 = MessageBox.Show(
                        "Стол в коттеджном стиле, " +
                        "\nКомплект стульев(4шт) в коттеджном стиле, " +
                        "\nхолодильник в коттеджном стиле, " +
                        "\nПосудомоечная машина в коттеджном стиле, " +
                        "\nКухонный гарнитур в коттеджном стиле, " +
                        "\nМикроволновка в коттеджном стиле, " +
                        "\nДуховая печь в коттеджном стиле, " +
                        "\nВытижка в коттеджном стиле, " +
                        "\nЭлектрическая плита в коттеджном стиле", 
                        "\nВас устраивает этот список?",
                        MessageBoxButtons.YesNo);
                    if (result2 == DialogResult.Yes)
                        listBox1.BackColor = Color.Green;
                    if (result2 == DialogResult.No)
                        listBox1.BackColor = Color.Red;
                    break;
            }
           
        }
        
    }
}
