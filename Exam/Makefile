all: out.txt
	cat $<

out.txt: main.exe
	mono $< > $@

main.exe: main.cs radapt.dll vector.dll integrator.dll
	mcs $< -target:exe -reference:radapt.dll,vector.dll,integrator.dll

radapt.dll: radapt.cs  vector.dll
	mcs $< -target:library -reference:vector.dll

vector.dll: vector.cs
	mcs $< -target:library

integrator.dll: integrator.cs
	mcs $< -target:library

clean:
	rm -r *.dll *.exe *.txt
