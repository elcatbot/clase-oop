import { useState } from "react";

function Login({ onLogin }){
    const [email, setEmail] = useState("")
    const [password, setPassword] = useState("")
    const [error, setError] = useState("");

    const DEMO_EMAIL = "demo@iue.edu.com"
    const DEMO_PASSWORD = "123456"

    function handleSubmit(event){
        event.preventDefault()

        if(email === DEMO_EMAIL && password == DEMO_PASSWORD){
            setError("");
            onLogin(email)
        } else {
            setError("Wrong email or password.")
        }
        
    }

    return(
        <form onSubmit={handleSubmit} style={{ maxWidth: 300, margin: "40px auto"}}>
            <h2>Login</h2>

            <label htmlFor="email">Email</label>
            <input 
                id="email" 
                type="email" 
                value={email} 
                onChange={(e) => setEmail(e.target.value)}
                style={{ display: "block", width: "100%", marginBottom: 11}}
            />

            <label htmlFor="password">Password</label>
            <input 
                id="password" 
                type="password" 
                value={password} 
                onChange={(e) => setPassword(e.target.value)}
                style={{ display: "block", width: "100%", marginBottom: 11}}
            />

            {error && <p style={{color: "red"}}>{error}</p> }

            <button type="submit">Log in</button>
        </form>
    )
}

export default Login