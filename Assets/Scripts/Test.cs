using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
# include<iostream>
    vector<string> parseCSVLine(string line)
    {
        using namespace boost;

   std::vector<std::string> vec;

// Tokenizes the input string
tokenizer<escaped_list_separator<char>> tk(line, escaped_list_separator<char>

('\\', ',', '\"'));
   for (auto i = tk.begin();  i!=tk.end();  ++i)
   vec.push_back(* i);

   return vec;
}

int main()
{
    std::string line = "hello,from,here";
    auto words = parseCSVLine(line);
    for (auto it = words.begin(); it != words.end(); it++)
    {
        std::cout << *it << std::endl;
    }
}