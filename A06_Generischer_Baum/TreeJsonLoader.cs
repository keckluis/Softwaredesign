using System;
using System.IO;
using System.Data;
using Newtonsoft.Json;

namespace A06_Generischer_Baum
{
    class TreeJsonLoader
    {
        public Tree<string>.TreeNode LoadJson(string path)
        {
            var tree = new Tree<string>();
            var root = tree.createNode("root");

            string json;
            try 
            {
                using (StreamReader sr = new StreamReader(path)) 
                {
                    json = sr.ReadToEnd();

                    DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(json);

                    DataTable dataTable = dataSet.Tables["nodes"];

                    foreach (DataRow row in dataTable.Rows)
                    {
                        if(root.FindNode(row["value"].ToString()) == null)
                        {
                            var node = tree.createNode(row["value"].ToString());
                            var parent = root.FindNode(row["parent"].ToString());
                            
                            if(parent == null)
                                tree.createNode(row["parent"].ToString());
                            
                            parent.appendChild(node);
                        }
                    }
                    return root;
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}