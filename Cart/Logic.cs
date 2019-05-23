using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class Logic
    {
        private string name, size, type_;
        private int price;
        private List<String> list;

        public string _Name
        {
            get { return name; }
            set { name = value; }
        }
        public string typeP
        {
            get { return type_; }
            set { type_ = value; }
        }
        public string _Size
        {
            get { return size; }
            set { size = value; }
        }
        public int _Price
        {
            get { return price; }
            set { price = value; }
        }
        public List<string> _list
        {
            get { return list; }
            set { list = value; }
        }
        public Logic()
        {
            list = null;
            name = "";
            size = "";
            price = 0;
            type_ = "";
        }
        public Logic(string _name, string _size)
        {
            list = null;
            name = _name;
            size = _size;
            price = 0;
            type_ = "";

        }
        public void Add()
        {
            list = new List<string>();
            list.Add(_Name);
            list.Add(_Size);
        }
        
        public void setShirtPrice()
        {
            if (type_ == "T-shirts" && size.ToLower() == "s")
            {
                price = 10;
            }
            else if (type_ == "T-shirts" && size.ToLower() == "m")
            {
                price = 20;
            }
            else if (type_ == "T-shirts" && size.ToLower() == "l")
            {
                price = 30;
            }
            //missing Golfer 
        }
        public void setPantsPrice()
        {
            if (type_ == "Pants" && size.ToLower() == "s")
            {
                price = 10 ;
            }
            else if (type_ == "Pants" && size.ToLower() == "m")
            {
                price = 20;
            }
            else if (type_ == "Pants" && size.ToLower() == "m")
            {
                price = 30;
            }
            //missing FormalPants 
        }
        public int total()
        {
            int total = 0;
            if (type_ == "Pants")
            {
                setPantsPrice();
            }
            else
            {
                setShirtPrice();
            }
            total = price;
            return total;
        }
        public void Display()
        {
           
            for (int i = 0; i < list.Count(); i+=2)
            {
                Console.WriteLine("Item name: " + list[i]);
                Console.WriteLine("Size: " + list[i + 1]);
            }
            Console.Read();
        }
    }
}
