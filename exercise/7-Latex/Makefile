ms.pdf: ms.tex exp_pyxplot.pdf
	pdflatex $<
	pdflatex $<
#	bibtex $<  //If I had bibliography, 
#	pdflatex $<  //I would need to recompile the latex

exp_pyxplot.pdf: exp.pyxplot.gpi out.exp.txt tab.exp.txt
	pyxplot $< # I have choosen pyxplot over gnuplot

out.exp.txt: main.exe
	mono $< > $@

tab.exp.txt: tab.exp.exe
	mono $< > $@	

tab.exp.exe: tab.exp.cs
	mcs $< -target:exe
		
main.exe: main.cs
	mcs $< -target:exe

clean:
	rm -r *.pdf *.aux [Oo]ut* *.exe *.log