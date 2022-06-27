all: out.txt
	cat $<

out.txt: main.exe
	mono $< > $@

main.exe: main.cs radapt.dll integrator.dll
	mcs $< -target:exe -reference:radapt.dll,integrator.dll

radapt.dll: radapt.cs  
	mcs $< -target:library 


integrator.dll: integrator.cs
	mcs $< -target:library

clean:
	rm -r *.dll *.exe *.txt
