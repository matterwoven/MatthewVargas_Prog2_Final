using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace MatthewVargas_Prog2_Final
{
    public class TaskFields
    {
        // Fields
        string? _completed;
        string? _name;
        string? _highimportance;
        string? _timesensitive;
        string? _description;

        public void TaskValues(string name, string highimportance, string timesensitive, string description, string completed)
        {
            _completed = completed;
            _name = name;
            _highimportance = highimportance;
            _timesensitive = timesensitive;
            _description = description;
        }
        // Properties
        public string Completed { get; set; }
        public string Name { get; set; }
        public string HighImportance { get; set; }
        public string TimeSensitive { get; set; }
        public string Description { get; set; }

        // Method
        // public string DisplayInformation() 
        public string DisplayInformation()
        {
            // Product Name: {_name}
            // ---------------------
            // Product Description : {_description}
            // Price : {_price.ToString("c");}
            // In Stock : {_inStock}

            string fullDisplay = ""; // ""
            fullDisplay += $"Name: {_name}\n";
            fullDisplay += $"----------------------\n";
            fullDisplay += $"Completed: {_highimportance}\n";
            fullDisplay += $"High Importance: {_highimportance}\n";
            fullDisplay += $"Time Sensitive: {_timesensitive}\n";
            fullDisplay += $"Description: {_description}\n";

            return fullDisplay;
        }
    }


}