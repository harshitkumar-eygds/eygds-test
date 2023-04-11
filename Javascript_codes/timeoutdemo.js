const first = () => {
    console.log('Hello User!');
    timeout();
    console.log('Your app is ready!');
};

const timeout = () => {
    setTimeout(() => {
        console.log('Please wait...');
    },2000);
};
first();