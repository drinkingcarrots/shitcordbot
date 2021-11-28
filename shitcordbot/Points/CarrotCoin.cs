using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using DSharpPlus;

namespace shitcordbot.Points
{
    public class CarrotCoin
    {
        public double PointFinder(ulong id)
        {
            string filepath = @"Z:\New folder (7)\bot\shitcordbot\shitcordbot\Points\Storage.txt";
            List<string> userPoints = File.ReadAllLines(filepath).ToList();
            
            string ID = Convert.ToString(id);

            foreach (string line in userPoints)
            {
                if(line.Contains(ID))
                {
                    double Points = Convert.ToDouble(line.Substring(19));
                    return Points;
                }
            }
            return -1000000;
        }
        public bool ProfileCreater(ulong id)
        {
            double created = PointFinder(id);

            if (created == -1000000)
            {
                string filepath = @"Z:\New folder (7)\bot\shitcordbot\shitcordbot\Points\Storage.txt";
                List<string> userPoints = File.ReadAllLines(filepath).ToList();

                userPoints.Add(id.ToString() + " 1000");

                File.WriteAllLines(filepath, userPoints);

                return true;
            }
            else return false;
        }
        public bool PointChange(ulong id, long points)
        {
            string filepath = @"Z:\New folder (7)\bot\shitcordbot\shitcordbot\Points\Storage.txt";
            List<string> userPoints = File.ReadAllLines(filepath).ToList();

            string ID = Convert.ToString(id);

            double total = PointFinder(id);

            for (int line = 0; line < userPoints.Count(); line++)
            {
                if (userPoints[line].Contains(ID))
                {
                    double diff = (double)((double)1 / (double)100000000) * (double)(total - 1000) * (double)(total - 1000) * (double)(total - 1000) * (double)(total - 1000) + 1;

                    total += (double)(points / diff);

                    userPoints.RemoveAt(line);

                    userPoints.Add(ID + " " + total.ToString());

                    File.WriteAllLines(filepath, userPoints);
                    return true;
                }
            }
            return false;
        }
        public ulong AtToId(string At)
        {
            ulong id = Convert.ToUInt64(At.Replace('>', ' ').Replace('<', ' ').Replace('@', ' ').Replace('!', ' ').Trim());

            return id;
        }
        public bool Negative(string message)
        {
            if (message.ToLower().Contains("bad") ||
                message.ToLower().Contains("hate") ||
                message.ToLower().Contains("suck") ||
                message.ToLower().Contains("terrible") ||
                message.ToLower().Contains("shit") ||
                message.ToLower().Contains("dumb") ||
                message.ToLower().Contains("stupid") ||
                message.ToLower().Contains("gay") ||
                message.ToLower().Contains("garbage") ||
                message.ToLower().Contains("jerk"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Positive(string message)
        {
            if (message.ToLower().Contains("good") ||
                message.ToLower().Contains("god") ||
                message.ToLower().Contains("best") ||
                message.ToLower().Contains("great") ||
                message.ToLower().Contains("cool") ||
                message.ToLower().Contains("love") ||
                message.ToLower().Contains("poggers") ||
                message.ToLower().Contains("awesome") ||
                message.ToLower().Contains("wonderful"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Government(string message, ulong id)
        {
            string[] positive = new string[] { "good", "god", "best", "great", "cool" };

            if (message.ToLower().Contains("taiwan") && message.ToLower().Contains("no") && message.ToLower().Contains("country"))
            {
                PointChange(id, 5);
            }
            else if (message.ToLower().Contains("taiwan") && message.ToLower().Contains("country") && message.ToLower().Contains("no") != true)
            {
                PointChange(id, -20);
            }
            else if (message.ToLower().Contains("carrot") && message.ToLower().Contains("no") && Positive(message) == true)
            {
                PointChange(id, -25);
            }
            else if (message.ToLower().Contains("carrot") && Negative(message) == true)
            {
                PointChange(id, -25);
            }
            else if (message.ToLower().Contains("carrot") && Positive(message) == true && Negative(message) == false)
            {
                PointChange(id, 10);
            }
            else if (message.ToLower().Contains("femboy") && Positive(message) == true)
            {
                PointChange(id, -20);
            }
            else if (message.ToLower().Contains("videogame") && Positive(message) == true)
            {
                PointChange(id, -20);
            }
            else if (message.ToLower().Contains("china") && Negative(message) == true)
            {
                PointChange(id, -20);
            }
            else if (message.ToLower().Contains("china") && Positive(message) == true && Negative(message) == false)
            {
                PointChange(id, 5);
            }
            else if (message.ToLower().Contains("tiananmen"))
            {
                PointChange(id, -35);
            }
            else if (message.ToLower().Contains("avocado") && Negative(message) == true)
            {
                PointChange(id, 10);
            }
            else if (message.ToLower().Contains("avocado") && Negative(message) == false)
            {
                PointChange(id, -20);
            }
            else
            {
                PointChange(id, 1);
            }
        }
    }
}
