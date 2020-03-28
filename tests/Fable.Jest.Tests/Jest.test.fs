﻿module Tests

open Fable.Jest

let myPromise = promise { return 1 + 1 }
    
let myAsync = async { return 1 + 1 }

Jest.describe("can run basic tests", (fun () ->
    Jest.test("running a test", (fun () ->
        Jest.expect(1+1).toEqual(2)
    ))

    Jest.test("running a promise test", (fun () ->
        Jest.expect(myPromise).resolves.toEqual(2)
        Jest.expect(myPromise).resolves.not.toEqual(1)
    ))

    Jest.test("running an async test", (fun () ->
        Jest.expect(myAsync).toEqual(2)
    ))
))

Jest.describe("how to run a test like test.each", (fun () ->
    Jest.test("same functionality as test.each", (fun () ->
        for (input, output) in [|(1, 2);(2, 3);(3, 4)|] do 
            Jest.expect(input + 1).toEqual(output)
    ))
))

Jest.describe("tests with the skip modifier don't get run", (fun () ->
    Jest.test.skip("adds", (fun () ->
        Jest.expect(true).toEqual(false)
    ))
    Jest.test("this should execute", (fun () ->
        Jest.expect(true).toEqual(true)
    ))
))

Jest.describe("todo tests give us our todo", (fun () ->
    Jest.test.todo "Do this!"
))

Jest.describe.skip("these shouldn't run", (fun () ->
    Jest.test("this shouldn't run", (fun () ->
        Jest.expect(true).toEqual(false)
    ))
    Jest.test("this shouldn't run either", (fun () ->
        Jest.expect(true).toEqual(false)
    ))
))
