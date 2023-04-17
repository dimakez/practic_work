string[] arr = new string[4] {"adfasddf","sr","sdfs","456456"};
string[] res = new string[0];
for (int i = 0; i<4; i++){    
    if(arr[i].Length < 3)
    {
        int length = arr.Length + 1;
        Array.Resize(ref res, length);  
        res[length-1] =  arr[i]; 
    }        
}

for (int j=0; j<res.Length; j++)
{
    Console.WriteLine(res[j]);
}