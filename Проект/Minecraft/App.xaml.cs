using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Minecraft.BD;

namespace Minecraft
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Minecraft_MusicEntities BD = new Minecraft_MusicEntities();
    }
}
