all: Out.txt
	cat Out.txt

Out.txt: main.exe
	mono main.exe > Out.txt

main.exe: main.cs cmath.dll
	mcs -t:exe -out:$@ $(addprefix -r:,$(filter %.dll,$^)) $<

CMATHDIR = /home/kraghbali/Documents/prakprogF22/prog/exercise/complex/class/files
cmath.dll: $(CMATHDIR)/complex.cs $(CMATHDIR)/cmath.cs
	mcs -t:library -out:./$@ $^

clean:
	$(RM) *.exe *.dll [Oo]ut*.txt