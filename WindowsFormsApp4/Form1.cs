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
        Dictionary<string, List<string>> furniture;
        public Form1()
        {
            InitializeComponent();
            price = new List<string>()
            {
                "Стол в фермерском стиле","Комплект стульев(4шт) в фермерском стиле","холодильник в фермерском стиле","Посудомоечная машина в фермерском стиле","Кухонный гарнитур в фермерском стиле","Микроволновка в фермерском стиле","Духовая печь в фермерском стиле","Вытижка в фермерском стиле","Раковина в фермерском стиле","Электрическая плита в фермерском стиле",
                  "Стол в современном стиле","Комплект стульев(4шт) в современном стиле","холодильник в современном стиле","Посудомоечная машина в современном стиле","Кухонный гарнитур в современном стиле","Микроволновка в современном стиле","Духовая печь в современном стиле","Вытижка в современном стиле","Раковина в современном стиле","Электрическая плита в современном стиле",
                   "Стол в коттеджном стиле","Комплект стульев(4шт) в коттеджном стиле","холодильник в коттеджном стиле","Посудомоечная машина в коттеджном стиле","Кухонный гарнитур в коттеджном стиле","Микроволновка в коттеджном стиле","Духовая печь в коттеджном стиле","Вытижка в коттеджном стиле","Раковина в коттеджном стиле","Электрическая плита в коттеджном стиле"
            };
            
            furniture = new Dictionary<string, List<string>>()
            {
                {
                    "300,000 Тенге", new List<string>()
                    {
                        "Стол в фермерском стиле","Комплект стульев(4шт) в фермерском стиле","холодильник в фермерском стиле","Посудомоечная машина в фермерском стиле","Кухонный гарнитур в фермерском стиле","Микроволновка в фермерском стиле","Духовая печь в фермерском стиле","Вытижка в фермерском стиле","Раковина в фермерском стиле","Электрическая плита в фермерском стиле"
                    }
                },
                {
                    "750,000 Тенге", new List<string>()
                    {
                        "Стол в современном стиле","Комплект стульев(4шт) в современном стиле","холодильник в современном стиле","Посудомоечная машина в современном стиле","Кухонный гарнитур в современном стиле","Микроволновка в современном стиле","Духовая печь в современном стиле","Вытижка в современном стиле","Раковина в современном стиле","Электрическая плита в современном стиле"
                    }
                },
                {
                    "1,500,000 Тенге", new List<string>()
                    {
                         "Стол в коттеджном стиле","Комплект стульев(4шт) в коттеджном стиле","холодильник в коттеджном стиле","Посудомоечная машина в коттеджном стиле","Кухонный гарнитур в коттеджном стиле","Микроволновка в коттеджном стиле","Духовая печь в коттеджном стиле","Вытижка в коттеджном стиле","Раковина в коттеджном стиле","Электрическая плита в коттеджном стиле"
                    }
                }
            };
            price.Sort();
            foreach(var item in furniture)
            {
                item.Value.Sort();
            }
            for (int i = 0; i < price.Count; i++)
            {
                listBox1.Items.Add(price[i]);
            }
            foreach (var item in furniture)
            {
                listBox2.Items.Add(item.Key);
            }
        }
       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Text = price.ToString();
        }
       
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach(var item in furniture)
            {
                if(listBox2.SelectedItem.ToString() == item.Key)
                {
                    foreach(var element in furniture[item.Key])
                    {
                        listBox2.Items.Add(element);
                    }
                }
            }
        }
    }
}
