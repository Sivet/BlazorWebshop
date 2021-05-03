using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace BlazorWebshop.Data
{
    class ImageService
    {
        private static readonly string path = @"\ImagesFolder\";
        IEnumerable<string> filesNames;
        static List<Img> imageList;
        public  ImageService()
        {
            DirectoryInfo folder = new DirectoryInfo("wwwroot"+path);
            FileInfo[] fileHandle = folder.GetFiles("*.*", SearchOption.AllDirectories);
            filesNames = fileHandle.Select(file => file.Name);

            imageList = new List<Img>();
            foreach(var item in filesNames){
                imageList.Add(new Img(path, item));
            }
            foreach(var item in imageList){
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Path);
            }
        }
        public Task<List<Img>> getImages(){
            return Task.FromResult(imageList);
        }
    }
}