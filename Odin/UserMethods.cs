/*
 * Created by Ranorex
 * User: LLevicky
 * Date: 12.7.2016
 * Time: 13:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Reflection;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

using System.Runtime.InteropServices;

namespace Odin
{
	/// <summary>
	/// Description of UserMethods.
	/// </summary>
	public class UserMethods
	{
		protected List<string> files = new List<string>();
		protected static string bin = new Uri(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)).LocalPath;
		protected string temp = (new DirectoryInfo(bin)).Parent.Parent.Parent.Parent.FullName.ToString();
		
		
				
		public UserMethods()
		{
			
		}
		
		public void Check()
		{
        	MessageBox.Show(temp);
        }
		
		public void MouseShift()
		{
			Mouse.MoveTo(Mouse.Position.X - 5, Mouse.Position.Y);
		}
		
		public void Snap(string path, string title)
        {
         	Delay.Milliseconds(500);
         	MouseShift();
         	Ranorex.Controls.ProgressForm.Hide();
         	Screen[] screens = Screen.AllScreens;
         	Rectangle borders = new Rectangle(screens[0].Bounds.X, screens[0].Bounds.Y, screens[0].Bounds.Width, screens[0].Bounds.Height);
         	
         	using(Bitmap map = new Bitmap(borders.Width, borders.Height))
        	{
        		using(Graphics snap = Graphics.FromImage(map))
        		{
        			snap.CopyFromScreen(borders.X,borders.Y, 0,0, borders.Size);
        		}
        		map.Save(path+title+".png", ImageFormat.Png);
        	}
        	
        }
		
		public void cleanClick(RepoItemInfo obj)
		{
			var ad = obj.CreateAdapter<Unknown>(true);
			
			WebElement ele = ad.Element;
			if(!ele.Parent.Visible)
				ele.Parent.EnsureVisible();
			
			Mouse.Click(ele);
			Delay.Milliseconds(500);
		}
		
		public void cleanMove(RepoItemInfo obj)
		{
			var ad = obj.CreateAdapter<Unknown>(true);
			
			WebElement ele = ad.Element;
			Mouse.MoveTo(ele);
			Delay.Milliseconds(500); 
		}
		
		public static string RandomString(int length)
  		{
    		const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    		var random = new Random();
    		return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
		}
		
		public void createDummyFile(string fileName, string targetFolder)
		{
			// Creates target folder location.
			createDummyFolder(targetFolder);
			// Generates random number between 1000 and 1500000.
			Random rnd = new Random();
			int length = rnd.Next(1000, 1500000);
			// Creates text file of given name (even Something.png) in target folder with random text of a random length. Therefore the file has some actual random size to it and can be uploaded to OneDrive.
			File.WriteAllText(fileName, RandomString(length));
			
		}
		
		public void createFilesFromList(string language, string targetFolder)
		{
			try{
				// Opens txt file with file list and creates them in target location.
				bin = bin + targetFolder;
				string fileList = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) + "Template\\" + language + "\\FileList.txt";
				setFiles(fileList);
				
				foreach(string file in files)
				{
					createDummyFile(file, bin);
				}
			}catch(Exception err){
				MessageBox.Show(err.ToString() + "\r" + err.Message.ToString());
			}
		}
		
		public void deleteDirectory(string directory)
		{
			Directory.Delete(directory, true);
		}
		
		public void createDummyFolder(string folder)
		{
			if(!Directory.Exists(folder))
				Directory.CreateDirectory(folder);
		}
		
		public void setFiles(string filesList)
		{
			System.IO.StreamReader file = new System.IO.StreamReader(filesList);
			string line;
			while((line = file.ReadLine()) != null)
			{
				files.Add(bin + "\\" + line);
			}
			file.Close();
		}
		
		public List<string> getPath()
		{
			if(files.Any())
			{
				return files;
			}else{
				return null;
			}
		}
		
    public void Logger(string data, int row,string lang)
        {
    		try
        	{
        		string url = (File.Exists(data.Substring(0,data.IndexOf(".txt")) + "_" + lang + ".txt")) ? data.Substring(0,data.IndexOf(".txt")) + "_" + lang + ".txt" : data;
        		string[] log = File.ReadAllLines(url);
        	
        		char[] separ = {Convert.ToChar(9)};
        		string[] text;
        		int i = 0;
        		
        		while(i != log.Length)
        		{
        			if(log[i].Contains("Position"))
        				break;
        			
        			i++;
        		}
        		
				i++;
        		
        		text = log[i + row].Split(separ, StringSplitOptions.RemoveEmptyEntries);
        		log[i + row] = separ[0] + text[0] + separ[0] + Mouse.Position.X + separ[0] + Mouse.Position.Y + separ[0] + text[3];
        		i++;
        		if(!log[i + row].Equals(""))
        		{        			
        			text = log[i + row].Split(separ, StringSplitOptions.RemoveEmptyEntries);
					log[i + row] = separ[0] + text[0] + separ[0] + Mouse.Position.X + separ[0] + Mouse.Position.Y + separ[0] + text[3];
        		}
				

				url = (url.Equals(data)) ? url.Substring(0,url.IndexOf(".txt")) + "_" + lang + ".txt" : url;

        		File.WriteAllLines(url, log);
        	}
        	catch(Exception err)
        	{
        		MessageBox.Show(err.ToString());
        	}
        	
        	
        }
		
		
	}
}
