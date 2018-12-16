weight=float(input("Peso del equipo:" ))
a=0
vitalitystats=[47,50,55,60,65,70,75,80,85,90,95,100,105,110,115,120,125,130,135,139]
vitalitylvl=[7,10,15,20,25,30,35,40,45,50,55,60,65,70,75,80,85,90,95,99]
MAX=20
finished=0
rollpercen=0
Havel=0
Fap=0
vit=0
hringpercent=0
fringpercent=0
chain=1
rings="N"

#--BEGIN--
print("fast(1), regular(2) or slow(3)?")
roll=int(input())
if roll == 1:
	#fast roll
    rollpercen=29.9
elif roll == 2:
	#medium roll
    rollpercen=69.9
elif roll== 3:
	#fat roll
    rollpercen=99.9

#Ask for rings
print("Rings? Y/N")
rings=input()
if rings == "Y" or rings =="y":
	print("Havel(0), Havel+1(1), Havel+2(2), Havel+3(3), No ring(4)")
	Havel=int(input())
	if Havel == 0:
		#Havel
	    hringpercent+=0.15
	elif Havel == 1:
	    hringpercent+=0.17
	    #Havel +1
	elif Havel == 2:
	    hringpercent+=0.18
	    #Havel +2   
	elif Havel == 3:
	    hringpercent+=0.19
	    #Havel+3

	print("Fap(0), Fap+1(1), Fap+2(2), Fap+3(3), No ring(4)")
	Fap=int(input())
	if Fap == 0:
	    fringpercent+=0.05
	    #FAP
	elif Fap == 1:
	    fringpercent+=0.06
		#FAP+1	
	elif Fap == 2:
	    fringpercent+=0.07   
		#FAP+2
	elif Fap == 3:
	    fringpercent+=0.08
	    #FAP+3

	print("chain(0), No ring(1)")
	Chain=int(input())

	#Change Vitality stats CHAIN
	if chain == 0:
		for z in range(1,MAX):
			vitalitystats[z]=vitalitystats[z]+5
	#Change Vitality stats HAVEL
	if hringpercent != 0:
	    for x in range(1,MAX):
	        vitalitystats[x]+=vitalitystats[x]*hringpercent
	#Change Vitality stats FAP
	if fringpercent != 0:
	    for y in range(1,MAX):
 	    	    vitalitystats[y]+=vitalitystats[y]*fringpercent

#Calculate Necesary Vit to roll
vit=weight*100/rollpercen

#Search lvl
while finished==0:
    if vit<=vitalitystats[a]:
        finished=1
    else:
        a+=1
print(vitalitylvl[a])