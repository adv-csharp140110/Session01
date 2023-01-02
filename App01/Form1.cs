using System.Xml.Serialization;

namespace App01
{
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
            object obj2 = new Form1();
            myFunc(obj);

            // Garbage Collector

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
    }
}