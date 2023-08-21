function solution(arr)
{
    var newArr = [];
    for(var j = 0; j < arr.length; j++){
            if(arr[j]!=arr[j+1]){
                newArr.push(arr[j]);
            }
        }
    return newArr;
}
