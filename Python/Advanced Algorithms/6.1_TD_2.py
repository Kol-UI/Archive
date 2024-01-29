def DPTDCutRec(p, n, track):
    #print(track)
    if n == 0:
        return 0
    elif track[n] > 0:
        return track[n]
    else:
        for i in range(n):
            value = p[i] + DPTDCutRec(p, n-i-1, track)
            if value > track[n]:
                track[n] = value
        return track[n]

def DPTDCut(p):
    n = len(p)
    track = [0]*(n+1)
    return DPTDCutRec(p, n, track)


p = [3, 5, 10, 12, 14]
print(DPTDCut(p))
