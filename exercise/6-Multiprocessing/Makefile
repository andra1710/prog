all: Out.txt
	cat $<
Out.txt: main.exe
	mono $< > $@
main.exe: main.cs
	mcs $< -target:exe

clean:
	rm -r *.dll *.exe [Oo]ut* [Ll]og*
