function solution(arr)
{
    var newArr = [];
    for(var j = 0; j < arr.length && arr.length > 1; j++){
            if(arr[j]!=arr[j+1]){
                newArr.push(arr[j]);
            }
        }
    return newArr;
}