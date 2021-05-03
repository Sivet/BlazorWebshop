using System;

namespace BlazorWebshop.Data
{
    public class Img
    {
        public Img(string path, string name){
            Path = path + name;
            Name = name;
        }
        public string Path { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
    }
}