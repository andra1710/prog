all: out.txt
	cat $<

out.txt: main.exe
	mono $< > $@

main.exe: main.cs matrix.dll vector.dll eig.dll
	mcs $< -reference:matrix.dll,vector.dll,eig.dll

eig.dll: eig.cs vector.dll matrix.dll
	mcs $< -target:library -reference:vector.dll,matrix.dll

matrix.dll: matrix.cs vector.dll
	mcs $< -target:library -reference:vector.dll

vector.dll: vector.cs
	mcs $< -target:library

clean:
	rm -r *.dll *.exe *.txt
