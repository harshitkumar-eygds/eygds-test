function myDisplayer(var1)
{
    //document.getElementById("demo").innerHTML = var1;
    console.log(var1);
    document.write(var1);
}

let myPromise = new Promise(function(myResolve , myReject){ 
    let x = 0;
    if(x == 0)
        {
            myResolve("executed successfully");
        }
    else
        {
            myReject("Error...please check");
        }
    });

myPromise.then(
function(value) 
    {
        myDisplayer(value);
    },
function(error) 
    {
        myDisplayer(error);
    }
);