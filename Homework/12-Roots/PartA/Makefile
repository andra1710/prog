all: out.txt
	cat $<

out.txt: main.exe
	mono $< > $@

main.exe: main.cs roots.dll vector.dll
	mcs $< -reference:roots.dll,vector.dll

roots.dll: roots.cs QRGS.dll matrix.dll vector.dll
	mcs $< -target:library -reference:QRGS.dll,matrix.dll,vector.dll

QRGS.dll: QRGS.cs matrix.dll vector.dll
	mcs $< -target:library -reference:matrix.dll,vector.dll

matrix.dll: matrix.cs vector.dll
	mcs $< -target:library -reference:vector.dll

vector.dll: vector.cs
	mcs $< -target:library

clean:
	rm -r *.dll *.exe *.txt
