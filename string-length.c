#include <stdio.h>

int main() {
  char word[];
  int i, len = 0;
  
  printf("Enter string to get length of: \n");
  scanf("%s", &word);
  
  while(true) {
    (word[i]=="\n") ? break : len += 1;
    i += 1;
  }
  printf("String length: %d", len)
}
