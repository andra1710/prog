all: gamma.pyxplot.png loggamma.pyxplot.png

gamma.pyxplot.png: gamma.data.txt tabular.values.txt Makefile
	echo '\
		set terminal png \n\
		set output "$@" \n\
		set xlabel "$$ x $$" \n\
		set ylabel "$$ y $$" \n\
		set title "The Gamma function" \n\
		set key right bottom \n\
		plot [-5:5] [-15:15] "$<" index 0 using 1:2 with lines title "$$\Gamma (x)$$",\
		"tabular.values.txt" using 1:2 with points pointtype 2 title "tab" \n\
	'| tee log.gpi | pyxplot

loggamma.pyxplot.png: gamma.data.txt tabular.values.txt Makefile
	echo '\
		set terminal png \n\
		set output "$@" \n\
		set xlabel "$$ x $$" \n\
		set xlabel "$$ y $$" \n\
		set title "Logarithm of the Gamma function" \n\
		set key left top \n\
		plot [0:10] "$<" index 0 using 1:3 with lines title "$$\log \left( \Gamma (x) \right)$$",\
		"tabular.values.txt" using 1:3 with points pointtype 2 title "tab" \n\
	'| tee log.gpi | pyxplot


gamma.data.txt: main.exe
	mono $< > $@

main.exe: main.cs
	mcs $< -target:exe

clean:
	rm -r *.png log* [Oo]ut* *.exe
