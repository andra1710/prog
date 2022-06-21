all: Out.txt
	cat Out.txt

Out.txt: main.exe
	mono $< > $@

main.exe: main.cs table.dll
	mcs -target:exe -out:$@ -reference:table.dll $<

table.dll: table.cs
	mcs $< -target:library -out:table.dll

clean:
	rm -r *.exe *.dll [Ou]ut.txt
