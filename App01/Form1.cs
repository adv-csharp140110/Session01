using System.Xml.Serialization;
using App01.Model;
using App01.UI;

namespace App01;

//Accessibility Level / Access Modifier
//public / internal
public partial class Form1 : Form
{
    //partial? 


    //method/property
    //private, public. internal, protect 
    public Form1()
    {
        InitializeComponent();
        //Variable
        // <type> <name> = <value>;


        int a = 1;
        int b;

        /*
         *  type:
         *      Value type:
         *          int, bool, float, structure, *string*, 
         *      Reference Type
         *          `new`
         *          Object
         *      
         *      Product p1 = new Product();
         *      p1.price = 100;
         *      Product p2 = p1;
         *      p2.price = 200;
         *
         *      p1.price ? 200 ✔️

         */

        /* Explicit صریح*/
        int Lenght = 10;


        /* Implicit ضمنی*/
        var count = 100000;
        //var xyz; 🐞

        /*
         * Naming Case
         *  PascalCase -> interface, class, method, property
         *  camelCase  -> variable, method private
         *  train_case ❌ 
         *  kebab-case ❌ css
         *  CONST_CASE -> const
         */

        //Boxing 
        var name = "ali";
        object obj = name;
        //object obj2 = new Form1();
        myFunc(obj);

        // Garbage Collector


        var p1 = new Product();
        // p1.Id alan random hast

        var p2 = new Product("Monitor", 500000);
        // p2.Id ? 0

        var p3 = new Product("Mouse");


        var p4 = new Product();
        p4.Name = "Keyboard";
        p4.Price = 100;


        //Object Initializer 🌟
        var p5 = new Product
        {
            Name = "Mic",
            Price = 100,
            Id = 2,
            Rate = 5
        };
    }

    private void myFunc(object param)
    {
        //Unboxing
        string s = Convert.ToString(param);
        /*
         * RunTime Error
         * Performance
         * Readability
         *
         *
         * Generics
         */

    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        //if (!listBoxCity.Items.Contains(textBoxName.Text))
        //{
        //    listBoxCity.Items.Add(textBoxName.Text);
        //}

        if (listBoxCity.Items.Contains(textBoxName.Text)) return;
        listBoxCity.Items.Add(textBoxName.Text);
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void buttonCalcAdd_Click(object sender, EventArgs e)
    {
        textBoxResult.Text = calc(textBoxA.Text, textBoxB.Text, CalcOp.Add).ToString();
    }
    
    private void buttonCalcSub_Click(object sender, EventArgs e)
    {
        textBoxResult.Text = calc(textBoxA.Text, textBoxB.Text, CalcOp.Sub).ToString();
    }

    private void buttonCalcMul_Click(object sender, EventArgs e)
    {
        textBoxResult.Text = calc(textBoxA.Text, textBoxB.Text, CalcOp.Mul).ToString();
    }

    private void buttonCalcDiv_Click(object sender, EventArgs e)
    {
        textBoxResult.Text = calc(textBoxA.Text, textBoxB.Text, CalcOp.Div).ToString();
    }

    private double calc(string strA, string strB, string op)
    {
        var a = Convert.ToInt32(strA);
        var b = Convert.ToInt32(strB);
        switch (op)
        {
            case "+": return a + b;
            case "-": return a - b;
            case "*": return a * b;
            case "/": return a / b;
            default: throw new ArgumentException("op not defined!");
        }

    }

    //Overload function
    private double calc(string strA, string strB, CalcOp op)
    {
        var a = Convert.ToInt32(strA);
        var b = Convert.ToInt32(strB);
        switch (op)
        {
            case CalcOp.Add: return a + b;
            case CalcOp.Sub: return a - b;
            case CalcOp.Mul: return a * b;
            case CalcOp.Div: return a / b;
            default: throw new ArgumentException("op not defined!");
        }
    }


    private double calcPattern(string strA, string strB, CalcOp op)
    {
        var a = Convert.ToInt32(strA);
        var b = Convert.ToInt32(strB);
        return op switch
        {
            CalcOp.Add => a + b,
            CalcOp.Sub => a - b,
            CalcOp.Mul => a * b,
            CalcOp.Div => a / b,
            _ => throw new ArgumentException("op not defined!")
        };
    }

    enum CalcOp
    {
        Add,
        Sub, 
        Mul,
        Div
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var form = new FormUsers(); 
        //form.Show();
        form.ShowDialog();

    }
}
