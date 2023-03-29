word = input("String to get length of: ")
strlen = 0
i = 0

while True:
  try:
    word[i]
    strlen += 1
  except IndexOutOfRangeError:
    break
  i += 1

  print(strlen)
