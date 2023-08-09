function solution(s) {
    var array = s.split('');
    var temp;
    for(var i = array.length-1; i>0; i--){
        var max = i;
        for(var j=i-1; j>-1; j--){
            if(array[max]>array[j]){
                max = j;
            }
        }
        
        if(max!=i){
            temp = array[max];
            array[max]=array[i];
            array[i]=temp;
        }
    }
    return array.join('');
}