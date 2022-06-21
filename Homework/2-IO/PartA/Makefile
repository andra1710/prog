all: Out.txt
	cat Out.txt

Out.txt: stdin.exe
	echo 1 2 3 4 5 > input.txt
	mono stdin.exe < input.txt > out.txt

stdin.exe: stdin.cs
	mcs -target:exe $<

clean: 
	rm *.exe *.dll [Oo]ut*.txt
