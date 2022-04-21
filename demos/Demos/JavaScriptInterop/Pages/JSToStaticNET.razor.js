
window.callnetfromjs = () => {
    DotNet.invokeMethodAsync('JavaScriptInteropDemo', 'NameOfTheMethod')
        .then(data => {
            alert(data);
        });
};
