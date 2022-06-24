all: erf.gnuplut.png erf.graph.png

erf.graph.png: erf.data.txt
	graph \
	-T png \
	$< > $@

erf.gnuplut.png: erf.pyxplot.png
	cat log.gpi | sed  's/pyxplot/gnuplot/' | tee log.gnu.gpi | gnuplot

erf.pyxplot.png: erf.data.txt erf.tab.txt Makefile
	echo "\
		set terminal png \n\
		set output '$@' \n\
		set xlabel '$$ x $$' \n\
		set ylabel '$$ y $$' \n\
		set title 'error function over the interval[ -2, 2]' \n\
		set key left top \n\
		plot [-2:2] [-1:1] '$<' index 0 using 1:2 with lines title 'erf',\
		'erf.tab.txt' using 1:2 with points pointtype 2 title 'tab' \n\
	"| tee log.gpi | pyxplot

erf.data.txt: main.exe
	mono $< > $@

#erf.tab.txt: Makefile

all: main.exe

%.exe: %.cs # any strings of .exe depends og .cs
	mcs $<

clean:
	rm -r *.png log* [Oo]ut* *.exe
