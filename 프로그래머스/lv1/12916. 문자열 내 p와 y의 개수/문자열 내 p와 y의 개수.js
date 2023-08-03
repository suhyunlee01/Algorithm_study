function solution(s){
    var sArray = s.split('');
    var pArray = [];
    var yArray = [];
    for(var i = 0; i < sArray.length; i++){
        if(sArray[i]=="p" || sArray[i]=="P"){
            pArray.push(sArray[i]);
        }else if(sArray[i]=="y" || sArray[i]=="Y"){
            yArray.push(sArray[i]);
        }
    }
    if(pArray.length == yArray.length){
        return true;
    }else if(pArray.length != yArray.length){
        return false;
    }
}