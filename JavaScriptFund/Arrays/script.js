window.onload = Task1;

function Task1() {
    var array = [],
        looper;

    for (looper = 0; looper < 20; looper += 1) {
        array.push(looper * 5);
    }
    document.getElementById('problem1Output').innerHTML = array;

    Task2();
}

function Task2() {
    var input1 = ['T', 'E', 'L', 'E', 'R', 'I', 'K'],
        input2 = ['U', 'N', 'I', 'S', 'O', 'F', 'T'],
        loopVar = 0,
        symbol,
        output = '',
        max = Math.max(input1.length, input2.length);

    for (loopVar = 0; loopVar < max; loopVar += 1) {
        if (input1[loopVar] > input2[loopVar]) {
            symbol = '>';
        }
        else if (input1[loopVar] == input2[loopVar]) {
            symbol = '=';
        }
        else {
            symbol = '<';
        }
        output += input1[loopVar] + ' ' + symbol + ' ' + input2[loopVar] + ' ; ';
    }
    document.getElementById('problem2Output').innerHTML = output;

    Task3();
}

function Task3() {
    var array = [2, 1, 1, 3, 3, 3, 2, 2, 2, 1],
        arrayLen = array.length,
        currentVar,
        currentVarCount=1,
        longestVar,
        longestVarCount=1,
        finalOutput = '',
        loopMaster;

    for (loopMaster = 1; loopMaster < arrayLen; loopMaster += 1) {

        if (array[loopMaster] == array[loopMaster - 1]) {
            currentVar = array[loopMaster];
            currentVarCount += 1;
        }
        else {
            if (currentVarCount > longestVarCount) {
                longestVarCount = currentVarCount;
                longestVar = currentVar;
            }
            currentVarCount = 1;
        }
    }

    for (loopMaster = 0 ; loopMaster < longestVarCount; loopMaster += 1) {
        if (loopMaster != longestVarCount - 1) {
            finalOutput += longestVar + ',';
        }
        else {
            finalOutput += longestVar;
        }
    }

    document.getElementById('problem3Output').innerHTML = finalOutput;

    Task4();
}

function Task4() {
    var arr = [3, 2, 3, 4, 2, 2, 4],
        arrLen = arr.length,
        currVal,
        currCo = 1,
        finalVal,
        finalCo = 0,
        finalOutput = '',
        loopzter;

    for(loopzter = 1; loopzter < arrLen; loopzter+=1) {
        if (arr[loopzter] == arr[loopzter-1] + 1) {
            currVal = arr[loopzter];
            currCo += 1;
        }
        else {
            if (currCo > finalCo) {
                finalCo = currCo;
                finalVal = currVal;
                currCo = 1;
            }
        }
    }

    for (loopzter = finalVal - (finalCo - 1) ; loopzter <= finalVal; loopzter += 1) {
        if (loopzter != finalVal) {
            finalOutput += loopzter + ',';
        }
        else {
            finalOutput += loopzter;
        }
    }

    document.getElementById('problem4Output').innerHTML = finalOutput;

    Task5();
}

function Task5() {

    var arrForHumanity = [16,3,5,41,101], //TEST WITH YOUR OWN :)
        arrayLen = arrForHumanity.length,
        isSortedTester = true,
        canContinue = false,
        timedValueTaker,
        numberLooper;

    while (canContinue == false) {

        isSortedTester = true;
        for (numberLooper = 1; numberLooper < arrayLen; numberLooper += 1) {
            if (arrForHumanity[numberLooper] < arrForHumanity[numberLooper - 1]) {
                isSortedTester = false;
                timedValueTaker = arrForHumanity[numberLooper];
                arrForHumanity[numberLooper] = arrForHumanity[numberLooper - 1];
                arrForHumanity[numberLooper - 1] = timedValueTaker;
                arrForHumanity;
                break;
            }
        }
        if (isSortedTester == true) {
            canContinue = true;
            break;
        }
    }
    document.getElementById('problem5Output').innerHTML = arrForHumanity;

    Task6();
}

function Task6() {

    var inputArr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
        lenghtForArr = inputArr.length,
        hashSetValues = [],
        canAdd = true,
        itemLooper,
        itemLooperPrim,
        currentVal = 0,
        curentCount = 0,
        finalValue = 0,
        finalValueCount = 0;

    hashSetValues.push(inputArr[0]);
    //MAKING OWN HASHSET -> hashSetValues
    for (itemLooper = 0; itemLooper < lenghtForArr; itemLooper += 1) {
        canAdd = true;
        for (itemLooperPrim = 0; itemLooperPrim < hashSetValues.length; itemLooperPrim += 1) {
            if (hashSetValues[itemLooperPrim] == inputArr[itemLooper]) {
                canAdd = false;
                break;
            }
        }
        if (canAdd == true) {
            hashSetValues.push(inputArr[itemLooper]);
        }
    }

    for (itemLooperPrim = 0; itemLooperPrim < hashSetValues.length; itemLooperPrim += 1) {
        curentCount = 0;
        currentVal = hashSetValues[itemLooperPrim];
        for (itemLooper = 0; itemLooper < lenghtForArr; itemLooper += 1) {

            if (inputArr[itemLooper] == hashSetValues[itemLooperPrim]) {
                curentCount += 1;
            }
        }
        if (curentCount > finalValueCount) {
            finalValueCount = curentCount;
            finalValue = currentVal;
        }
    }

    document.getElementById('problem6Output').innerHTML = finalValue + '&nbsp(' + finalValueCount + '&nbsptimes)';

    Task7();
}

function Task7() {

    var arrayContainer = [1, 2, 3, 4, 5, 6, 7, 8],
        searchedValue = 3,
        isFound = false,
        position = 0;

    while (isFound == false) {
        if (searchedValue == arrayContainer[(arrayContainer.length/2)|0]) {
            isFound = true;
            break;
        }
        else if (searchedValue > arrayContainer[(arrayContainer.length/2)|0]) {
            arrayContainer= arrayContainer.slice(((arrayContainer.length / 2)|0) + 1, arrayContainer.length);
        }
        else {
            arrayContainer=arrayContainer.slice(0,(arrayContainer.length / 2)|0);
        }
    }
    document.getElementById('problem7Output').innerHTML = 'is found:&nbsp'+isFound;

}