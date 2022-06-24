all: out.txt
	cat $<

out.txt: main.exe
	mono $< > $@

main.exe: main.cs radapt.dll
	mcs $< -target:exe -reference:radapt.dll

radapt.dll: radapt.cs 
	mcs $< -target:library 


clean:
	rm -r *.dll *.exe *.txt
