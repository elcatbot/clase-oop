function Home({user, onLogout}){
    return (
        <div style={{ maxWidth: 400, margin: "40px auto"}}>
            <h1>Home</h1>
            <p>Welcome, user! You are logged in.</p>
            <button onClick={onLogout}>Log out</button>
        </div>
    )
}

export default Home