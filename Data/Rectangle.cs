using System;
namespace blazorserver01.Data
{
    public class Rectangle {
        public int id { get; set; }
        public string color { get; set; }
        public Rectangle(int id,string color){
            
            this.color = color;
            this.id = id;
        } 

    }
}