all: out.txt
	cat out.txt

out.txt: fileio.exe
	mono fileio.exe -input:input.txt -output:out.txt

fileio.exe: fileio.cs
	mcs -target:exe $<

clean: 
	rm *.exe [Oo]ut*.txt
