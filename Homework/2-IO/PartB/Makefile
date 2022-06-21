all: Out.txt
	cat Out.txt

Out.txt: cmdline.exe
	mono $< 1 2 3 4 5 >$@

cmdline.exe: cmdline.cs
	mcs -target:exe $<

clean: 
	rm *.exe [Oo]ut*.txt
