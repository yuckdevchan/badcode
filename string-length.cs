using System;

class Program {
  string words;
  int len, i = 0;
  
  void Main() {
    Console.WriteLine("Enter string to get length of: ");
    words = Console.ReadLine();
    
    while(true) {
      try {
        char temp = words[i];
        len += 1;
      } catch(Exception e) {
        break;
      } finally {
        i += 1;
      }
    }
    
    Console.WriteLine(len);
  }
}
