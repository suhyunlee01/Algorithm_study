function solution(arr, divisor) {
    var newArray = [];
    for(var i = 0; i<arr.length; i++){
        if(arr[i] % divisor == 0){
            newArray.push(arr[i]);
        }
    }
    if(newArray==""){
        newArray.push(-1);
    }
    for(var a = 0; a < newArray.length-1; a++){
        for(var b = 0; b < newArray.length-1; b++){
            if(newArray[b] > newArray[b+1]){
                temp = newArray[b];
                newArray[b] = newArray[b+1];
                newArray[b+1] = temp;
            }
        }
    }
    return newArray;
}