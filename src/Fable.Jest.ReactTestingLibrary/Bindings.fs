﻿namespace Fable.Jest.ReactTestingLibrary

open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Feliz
open System
open System.Text.RegularExpressions

[<RequireQualifiedAccess>]
module Bindings =
    type Matcher =
        U3<string, Regex, string * HTMLElement -> bool>

    type MatcherOptions =
        abstract exact: bool option with get, set
        abstract normalizer: (string -> string) option with get, set

    [<RequireQualifiedAccess>]
    module MatcherOptions =
        let create exact normalizer =
            jsOptions<MatcherOptions> <| fun o ->
                o.exact <- exact
                o.normalizer <- normalizer

    type LabelTextMatcher =
        inherit MatcherOptions
        abstract selector: string option with get, set

    [<RequireQualifiedAccess>]
    module LabelTextMatcher =
        let create selector exact normalizer =
            jsOptions<LabelTextMatcher> <| fun o ->
                o.selector <- selector
                o.exact <- exact
                o.normalizer <- normalizer

    type TextMatcher =
        inherit MatcherOptions
        abstract selector: string option with get, set
        abstract ignore: U2<string, bool> option with get, set

    [<RequireQualifiedAccess>]
    module TextMatcher =
        let create selector ignore exact normalizer =
            jsOptions<TextMatcher> <| fun o ->
                o.selector <- selector
                o.ignore <- ignore
                o.exact <- exact
                o.normalizer <- normalizer

    type RoleMatcher =
        inherit MatcherOptions
        abstract hidden: bool option with get, set
        abstract name: Matcher option with get, set

    [<RequireQualifiedAccess>]
    module RoleMatcher =
        let create hidden name exact normalizer =
            jsOptions<RoleMatcher> <| fun o ->
                o.hidden <- hidden
                o.name <- name
                o.exact <- exact
                o.normalizer <- normalizer
    
    type Act =
        [<Emit("$0($1)")>]
        abstract invoke: callback: (unit -> unit) -> unit

    let actImport : Act = import "act" "@testing-library/react"

    type Configure =
        [<Emit("$0($1)")>]
        abstract invoke: options: IConfigureOptions -> unit

    let configureImport : Configure = import "configure" "@testing-library/react"

    type Cleanup =
        [<Emit("$0()")>]
        abstract invoke: unit -> unit

    let cleanupImport : Cleanup = import "cleanup" "@testing-library/react"

    type CreateEvent =
        abstract abort: node: HTMLElement * ?eventProperties:obj -> unit
        abstract animationEnd: node: HTMLElement * ?eventProperties:obj -> unit
        abstract animationIteration: node: HTMLElement * ?eventProperties:obj -> unit
        abstract animationStart: node: HTMLElement * ?eventProperties:obj -> unit
        abstract blur: node: HTMLElement * ?eventProperties:obj -> unit
        abstract canPlay: node: HTMLElement * ?eventProperties:obj -> unit
        abstract canPlayThrough: node: HTMLElement * ?eventProperties:obj -> unit
        abstract change: node: HTMLElement * ?eventProperties:obj -> unit
        abstract click: node: HTMLElement * ?eventProperties:obj -> unit
        abstract compositionEnd: node: HTMLElement * ?eventProperties:obj -> unit
        abstract compositionStart: node: HTMLElement * ?eventProperties:obj -> unit
        abstract compositionUpdate: node: HTMLElement * ?eventProperties:obj -> unit
        abstract contextMenu: node: HTMLElement * ?eventProperties:obj -> unit
        abstract copy: node: HTMLElement * ?eventProperties:obj -> unit
        abstract cut: node: HTMLElement * ?eventProperties:obj -> unit
        abstract dblClick: node: HTMLElement * ?eventProperties:obj -> unit
        abstract doubleClick: node: HTMLElement * ?eventProperties:obj -> unit
        abstract drag: node: HTMLElement * ?eventProperties:obj -> unit
        abstract dragEnd: node: HTMLElement * ?eventProperties:obj -> unit
        abstract dragEnter: node: HTMLElement * ?eventProperties:obj -> unit
        abstract dragExit: node: HTMLElement * ?eventProperties:obj -> unit
        abstract dragLeave: node: HTMLElement * ?eventProperties:obj -> unit
        abstract dragOver: node: HTMLElement * ?eventProperties:obj -> unit
        abstract dragStart: node: HTMLElement * ?eventProperties:obj -> unit
        abstract drop: node: HTMLElement * ?eventProperties:obj -> unit
        abstract durationChange: node: HTMLElement * ?eventProperties:obj -> unit
        abstract emptied: node: HTMLElement * ?eventProperties:obj -> unit
        abstract encrypted: node: HTMLElement * ?eventProperties:obj -> unit
        abstract ended: node: HTMLElement * ?eventProperties:obj -> unit
        abstract error: node: HTMLElement * ?eventProperties:obj -> unit
        abstract focus: node: HTMLElement * ?eventProperties:obj -> unit
        abstract focusIn: node: HTMLElement * ?eventProperties:obj -> unit
        abstract focusOut: node: HTMLElement * ?eventProperties:obj -> unit
        abstract gotPointerCapture: node: HTMLElement * ?eventProperties:obj -> unit
        abstract input: node: HTMLElement * ?eventProperties:obj -> unit
        abstract invalid: node: HTMLElement * ?eventProperties:obj -> unit
        abstract keyDown: node: HTMLElement * ?eventProperties:obj -> unit
        abstract keyPress: node: HTMLElement * ?eventProperties:obj -> unit
        abstract keyUp: node: HTMLElement * ?eventProperties:obj -> unit
        abstract load: node: HTMLElement * ?eventProperties:obj -> unit
        abstract loadedData: node: HTMLElement * ?eventProperties:obj -> unit
        abstract loadedMetadata: node: HTMLElement * ?eventProperties:obj -> unit
        abstract loadStart: node: HTMLElement * ?eventProperties:obj -> unit
        abstract lostPointerCapture: node: HTMLElement * ?eventProperties:obj -> unit
        abstract mouseDown: node: HTMLElement * ?eventProperties:obj -> unit
        abstract mouseEnter: node: HTMLElement * ?eventProperties:obj -> unit
        abstract mouseLeave: node: HTMLElement * ?eventProperties:obj -> unit
        abstract mouseMove: node: HTMLElement * ?eventProperties:obj -> unit
        abstract mouseOut: node: HTMLElement * ?eventProperties:obj -> unit
        abstract mouseOver: node: HTMLElement * ?eventProperties:obj -> unit
        abstract mouseUp: node: HTMLElement * ?eventProperties:obj -> unit
        abstract paste: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pause: node: HTMLElement * ?eventProperties:obj -> unit
        abstract play: node: HTMLElement * ?eventProperties:obj -> unit
        abstract playing: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pointerCancel: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pointerDown: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pointerEnter: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pointerLeave: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pointerMove: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pointerOut: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pointerOver: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pointerUp: node: HTMLElement * ?eventProperties:obj -> unit
        abstract popState: node: HTMLElement * ?eventProperties:obj -> unit        
        abstract progress: node: HTMLElement * ?eventProperties:obj -> unit
        abstract rateChange: node: HTMLElement * ?eventProperties:obj -> unit
        abstract reset: node: HTMLElement * ?eventProperties:obj -> unit
        abstract scroll: node: HTMLElement * ?eventProperties:obj -> unit
        abstract seeked: node: HTMLElement * ?eventProperties:obj -> unit
        abstract seeking: node: HTMLElement * ?eventProperties:obj -> unit
        abstract select: node: HTMLElement * ?eventProperties:obj -> unit
        abstract stalled: node: HTMLElement * ?eventProperties:obj -> unit
        abstract submit: node: HTMLElement * ?eventProperties:obj -> unit
        abstract suspend: node: HTMLElement * ?eventProperties:obj -> unit
        abstract timeUpdate: node: HTMLElement * ?eventProperties:obj -> unit
        abstract touchCancel: node: HTMLElement * ?eventProperties:obj -> unit
        abstract touchEnd: node: HTMLElement * ?eventProperties:obj -> unit
        abstract touchMove: node: HTMLElement * ?eventProperties:obj -> unit
        abstract touchStart: node: HTMLElement * ?eventProperties:obj -> unit
        abstract transitionEnd: node: HTMLElement * ?eventProperties:obj -> unit
        abstract volumeChange: node: HTMLElement * ?eventProperties:obj -> unit
        abstract waiting: node: HTMLElement * ?eventProperties:obj -> unit
        abstract wheel: node: HTMLElement * ?eventProperties:obj -> unit

    let createEventImport : CreateEvent = import "createEvent" "@testing-library/react"

    type ExpectDomReturn =
        abstract pass: bool
        [<Emit("$0()")>]
        abstract message: unit -> string

    type ExpectDom =
        static member inline toBeChecked (node: HTMLElement) : ExpectDomReturn = import "toBeChecked" "@testing-library/jest-dom/matchers"
        static member inline toBeDisabled (node: HTMLElement) : ExpectDomReturn = import "toBeDisabled" "@testing-library/jest-dom/matchers"
        static member inline toBeEnabled (node: HTMLElement) : ExpectDomReturn = import "toBeEnabled" "@testing-library/jest-dom/matchers"
        static member inline toBeEmpty (node: HTMLElement) : ExpectDomReturn = import "toBeEmpty" "@testing-library/jest-dom/matchers"
        static member inline toBeInTheDocument (node: HTMLElement) : ExpectDomReturn = import "toBeInTheDocument" "@testing-library/jest-dom/matchers"
        static member inline toBeInvalid (node: HTMLElement) : ExpectDomReturn = import "toBeInvalid" "@testing-library/jest-dom/matchers"
        static member inline toBeRequired (node: HTMLElement) : ExpectDomReturn = import "toBeRequired" "@testing-library/jest-dom/matchers"
        static member inline toBeValid (node: HTMLElement) : ExpectDomReturn = import "toBeValid" "@testing-library/jest-dom/matchers"
        static member inline toBeVisible (node: HTMLElement) : ExpectDomReturn = import "toBeVisible" "@testing-library/jest-dom/matchers"
        static member inline toContainElement (node: HTMLElement, element: HTMLElement option) : ExpectDomReturn = import "toContainElement" "@testing-library/jest-dom/matchers"
        static member inline toContainHTML (node: HTMLElement, htmlText: string) : ExpectDomReturn = import "toContainHTML" "@testing-library/jest-dom/matchers"
        static member inline toHaveAttribute (node: HTMLElement, attr: string, ?value: obj) : ExpectDomReturn = import "toHaveAttribute" "@testing-library/jest-dom/matchers"
        static member inline toHaveClass (node: HTMLElement, [<ParamArray>] classNames: string []) : ExpectDomReturn = import "toHaveClass" "@testing-library/jest-dom/matchers"
        static member inline toHaveFocus (node: HTMLElement) : ExpectDomReturn = import "toHaveFocus" "@testing-library/jest-dom/matchers"
        static member inline toHaveFormValues (node: HTMLElement, expectedValues: obj) : ExpectDomReturn = import "toHaveFormValues" "@testing-library/jest-dom/matchers"
        static member inline toHaveStyle (node: HTMLElement, css: obj) : ExpectDomReturn = import "toHaveStyle" "@testing-library/jest-dom/matchers"
        static member inline toHaveTextContent (node: HTMLElement, text: U2<string, System.Text.RegularExpressions.Regex>, ?options: obj) : ExpectDomReturn = import "toHaveTextContent" "@testing-library/jest-dom/matchers"
        static member inline toHaveValue (node: HTMLElement, value: U4<string, ResizeArray<string>, float, int>) : ExpectDomReturn = import "toHaveValue" "@testing-library/jest-dom/matchers"

    type Expect =
        abstract toBeInTheDocument: unit -> ExpectDomReturn

    type ExpectExports =
        [<Emit("expect($1)")>]
        abstract invoke : 'T -> Expect
        abstract extend: obj -> unit

    [<Global("expect")>]
    let expect : ExpectExports = jsNative

    let toBeInTheDocumentTest () =
        expect.extend(import "toBeInTheDocument" "@testing-library/jest-dom/matchers")

    type FireEvent =
        [<Emit("$0($1,$2)")>]
        abstract custom: node:HTMLElement * event:#Browser.Types.Event -> unit

        abstract abort: node: HTMLElement * ?eventProperties:obj -> unit
        abstract animationEnd: node: HTMLElement * ?eventProperties:obj -> unit
        abstract animationIteration: node: HTMLElement * ?eventProperties:obj -> unit
        abstract animationStart: node: HTMLElement * ?eventProperties:obj -> unit
        abstract blur: node: HTMLElement * ?eventProperties:obj -> unit
        abstract canPlay: node: HTMLElement * ?eventProperties:obj -> unit
        abstract canPlayThrough: node: HTMLElement * ?eventProperties:obj -> unit
        abstract change: node: HTMLElement * ?eventProperties:obj -> unit
        abstract click: node: HTMLElement * ?eventProperties:obj -> unit
        abstract compositionEnd: node: HTMLElement * ?eventProperties:obj -> unit
        abstract compositionStart: node: HTMLElement * ?eventProperties:obj -> unit
        abstract compositionUpdate: node: HTMLElement * ?eventProperties:obj -> unit
        abstract contextMenu: node: HTMLElement * ?eventProperties:obj -> unit
        abstract copy: node: HTMLElement * ?eventProperties:obj -> unit
        abstract cut: node: HTMLElement * ?eventProperties:obj -> unit
        abstract dblClick: node: HTMLElement * ?eventProperties:obj -> unit
        abstract doubleClick: node: HTMLElement * ?eventProperties:obj -> unit
        abstract drag: node: HTMLElement * ?eventProperties:obj -> unit
        abstract dragEnd: node: HTMLElement * ?eventProperties:obj -> unit
        abstract dragEnter: node: HTMLElement * ?eventProperties:obj -> unit
        abstract dragExit: node: HTMLElement * ?eventProperties:obj -> unit
        abstract dragLeave: node: HTMLElement * ?eventProperties:obj -> unit
        abstract dragOver: node: HTMLElement * ?eventProperties:obj -> unit
        abstract dragStart: node: HTMLElement * ?eventProperties:obj -> unit
        abstract drop: node: HTMLElement * ?eventProperties:obj -> unit
        abstract durationChange: node: HTMLElement * ?eventProperties:obj -> unit
        abstract emptied: node: HTMLElement * ?eventProperties:obj -> unit
        abstract encrypted: node: HTMLElement * ?eventProperties:obj -> unit
        abstract ended: node: HTMLElement * ?eventProperties:obj -> unit
        abstract error: node: HTMLElement * ?eventProperties:obj -> unit
        abstract focus: node: HTMLElement * ?eventProperties:obj -> unit
        abstract focusIn: node: HTMLElement * ?eventProperties:obj -> unit
        abstract focusOut: node: HTMLElement * ?eventProperties:obj -> unit
        abstract gotPointerCapture: node: HTMLElement * ?eventProperties:obj -> unit
        abstract input: node: HTMLElement * ?eventProperties:obj -> unit
        abstract invalid: node: HTMLElement * ?eventProperties:obj -> unit
        abstract keyDown: node: HTMLElement * ?eventProperties:obj -> unit
        abstract keyPress: node: HTMLElement * ?eventProperties:obj -> unit
        abstract keyUp: node: HTMLElement * ?eventProperties:obj -> unit
        abstract load: node: HTMLElement * ?eventProperties:obj -> unit
        abstract loadedData: node: HTMLElement * ?eventProperties:obj -> unit
        abstract loadedMetadata: node: HTMLElement * ?eventProperties:obj -> unit
        abstract loadStart: node: HTMLElement * ?eventProperties:obj -> unit
        abstract lostPointerCapture: node: HTMLElement * ?eventProperties:obj -> unit
        abstract mouseDown: node: HTMLElement * ?eventProperties:obj -> unit
        abstract mouseEnter: node: HTMLElement * ?eventProperties:obj -> unit
        abstract mouseLeave: node: HTMLElement * ?eventProperties:obj -> unit
        abstract mouseMove: node: HTMLElement * ?eventProperties:obj -> unit
        abstract mouseOut: node: HTMLElement * ?eventProperties:obj -> unit
        abstract mouseOver: node: HTMLElement * ?eventProperties:obj -> unit
        abstract mouseUp: node: HTMLElement * ?eventProperties:obj -> unit
        abstract paste: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pause: node: HTMLElement * ?eventProperties:obj -> unit
        abstract play: node: HTMLElement * ?eventProperties:obj -> unit
        abstract playing: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pointerCancel: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pointerDown: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pointerEnter: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pointerLeave: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pointerMove: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pointerOut: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pointerOver: node: HTMLElement * ?eventProperties:obj -> unit
        abstract pointerUp: node: HTMLElement * ?eventProperties:obj -> unit
        abstract popState: node: HTMLElement * ?eventProperties:obj -> unit        
        abstract progress: node: HTMLElement * ?eventProperties:obj -> unit
        abstract rateChange: node: HTMLElement * ?eventProperties:obj -> unit
        abstract reset: node: HTMLElement * ?eventProperties:obj -> unit
        abstract scroll: node: HTMLElement * ?eventProperties:obj -> unit
        abstract seeked: node: HTMLElement * ?eventProperties:obj -> unit
        abstract seeking: node: HTMLElement * ?eventProperties:obj -> unit
        abstract select: node: HTMLElement * ?eventProperties:obj -> unit
        abstract stalled: node: HTMLElement * ?eventProperties:obj -> unit
        abstract submit: node: HTMLElement * ?eventProperties:obj -> unit
        abstract suspend: node: HTMLElement * ?eventProperties:obj -> unit
        abstract timeUpdate: node: HTMLElement * ?eventProperties:obj -> unit
        abstract touchCancel: node: HTMLElement * ?eventProperties:obj -> unit
        abstract touchEnd: node: HTMLElement * ?eventProperties:obj -> unit
        abstract touchMove: node: HTMLElement * ?eventProperties:obj -> unit
        abstract touchStart: node: HTMLElement * ?eventProperties:obj -> unit
        abstract transitionEnd: node: HTMLElement * ?eventProperties:obj -> unit
        abstract volumeChange: node: HTMLElement * ?eventProperties:obj -> unit
        abstract waiting: node: HTMLElement * ?eventProperties:obj -> unit
        abstract wheel: node: HTMLElement * ?eventProperties:obj -> unit
        
    let fireEventImport : FireEvent = import "fireEvent" "@testing-library/react"

    type GetNodeText =
        [<Emit("$0($1)")>]
        abstract invoke: node:HTMLElement -> string

    let getNodeTextImport : GetNodeText = import "getNodeText" "@testing-library/react"

    type GetRoles =
        [<Emit("$0($1)")>]
        abstract invoke: node:HTMLElement -> obj

    let getRolesImport : GetRoles = import "getRoles" "@testing-library/react"

    type IsInaccessible =
        [<Emit("$0($1)")>]
        abstract invoke: node:HTMLElement -> bool

    let isInaccessibleImport : IsInaccessible = import "isInaccessible" "@testing-library/react"

    type LogRoles =
        [<Emit("$0($1)")>]
        abstract invoke: node:HTMLElement -> unit

    let logRolesImport : LogRoles = import "logRoles" "@testing-library/react"

    type PrettyDOM =
        [<Emit("$0($1)")>]
        abstract invoke: node:HTMLElement * ?maxLength: int * ?options:IPrettyDOMOptions -> string

    let prettyDOMImport : PrettyDOM = import "prettyDOM" "@testing-library/react"

    type QueriesForElement =
        abstract getByLabelText: matcher:Matcher * ?options: LabelTextMatcher -> HTMLElement
        abstract getAllByLabelText: matcher:Matcher * ?options: LabelTextMatcher -> ResizeArray<HTMLElement>
        abstract queryByLabelText: matcher:Matcher * ?options: LabelTextMatcher -> HTMLElement option
        abstract queryAllByLabelText: matcher:Matcher * ?options: LabelTextMatcher -> ResizeArray<HTMLElement>
        abstract findByLabelText: matcher:Matcher * ?options: LabelTextMatcher -> JS.Promise<HTMLElement>
        abstract findAllByLabelText: matcher:Matcher * ?options: LabelTextMatcher -> JS.Promise<ResizeArray<HTMLElement>>
    
        abstract getByPlaceholderText: matcher:Matcher * ?options: MatcherOptions -> HTMLElement
        abstract getAllByPlaceholderText: matcher:Matcher * ?options: MatcherOptions -> ResizeArray<HTMLElement>
        abstract queryByPlaceholderText: matcher:Matcher * ?options: MatcherOptions -> HTMLElement option
        abstract queryAllByPlaceholderText: matcher:Matcher * ?options: MatcherOptions -> ResizeArray<HTMLElement>
        abstract findByPlaceholderText: matcher:Matcher * ?options: MatcherOptions -> JS.Promise<HTMLElement>
        abstract findAllByPlaceholderText: matcher:Matcher * ?options: MatcherOptions -> JS.Promise<ResizeArray<HTMLElement>>
    
        abstract getByText: matcher:Matcher * ?options: TextMatcher -> HTMLElement
        abstract getAllByText: matcher:Matcher * ?options: TextMatcher -> ResizeArray<HTMLElement>
        abstract queryByText: matcher:Matcher * ?options: TextMatcher -> HTMLElement option
        abstract queryAllByText: matcher:Matcher * ?options: TextMatcher -> ResizeArray<HTMLElement>
        abstract findByText: matcher:Matcher * ?options: TextMatcher -> JS.Promise<HTMLElement>
        abstract findAllByText: matcher:Matcher * ?options: TextMatcher -> JS.Promise<ResizeArray<HTMLElement>>
    
        abstract getByTitle: matcher:Matcher * ?options: MatcherOptions -> HTMLElement
        abstract getAllByTitle: matcher:Matcher * ?options: MatcherOptions -> ResizeArray<HTMLElement>
        abstract queryByTitle: matcher:Matcher * ?options: MatcherOptions -> HTMLElement option
        abstract queryAllByTitle: matcher:Matcher * ?options: MatcherOptions -> ResizeArray<HTMLElement>
        abstract findByTitle: matcher:Matcher * ?options: MatcherOptions -> JS.Promise<HTMLElement>
        abstract findAllByTitle: matcher:Matcher * ?options: MatcherOptions -> JS.Promise<ResizeArray<HTMLElement>>

        abstract getByDisplayValue: matcher:Matcher * ?options: MatcherOptions -> HTMLElement
        abstract getAllByDisplayValue: matcher:Matcher * ?options: MatcherOptions -> ResizeArray<HTMLElement>
        abstract queryByDisplayValue: matcher:Matcher * ?options: MatcherOptions -> HTMLElement option
        abstract queryAllByDisplayValue: matcher:Matcher * ?options: MatcherOptions -> ResizeArray<HTMLElement>
        abstract findByDisplayValue: matcher:Matcher * ?options: MatcherOptions -> JS.Promise<HTMLElement>
        abstract findAllByDisplayValue: matcher:Matcher * ?options: MatcherOptions -> JS.Promise<ResizeArray<HTMLElement>>

        abstract getByRole: matcher:Matcher * ?options: MatcherOptions -> HTMLElement
        abstract getAllByRole: matcher:Matcher * ?options: MatcherOptions -> ResizeArray<HTMLElement>
        abstract queryByRole: matcher:Matcher * ?options: MatcherOptions -> HTMLElement option
        abstract queryAllByRole: matcher:Matcher * ?options: MatcherOptions -> ResizeArray<HTMLElement>
        abstract findByRole: matcher:Matcher * ?options: MatcherOptions -> JS.Promise<HTMLElement>
        abstract findAllByRole: matcher:Matcher * ?options: MatcherOptions -> JS.Promise<ResizeArray<HTMLElement>>

        abstract getByTestId: matcher:Matcher * ?options: MatcherOptions -> HTMLElement
        abstract getAllByTestId: matcher:Matcher * ?options: MatcherOptions -> ResizeArray<HTMLElement>
        abstract queryByTestId: matcher:Matcher * ?options: MatcherOptions -> HTMLElement option
        abstract queryAllByTestId: matcher:Matcher * ?options: MatcherOptions -> ResizeArray<HTMLElement>
        abstract findByTestId: matcher:Matcher * ?options: MatcherOptions -> JS.Promise<HTMLElement>
        abstract findAllByTestId: matcher:Matcher * ?options: MatcherOptions -> JS.Promise<ResizeArray<HTMLElement>>

    type Render =
        inherit QueriesForElement
        abstract baseElement: HTMLElement with get
        abstract container: HTMLElement with get

        abstract act: unit -> unit
        abstract asFragment: unit -> DocumentFragment
        abstract debug: unit -> unit
        abstract rerender: ReactElement -> unit
        abstract unmount: unit -> unit

    type RenderImport =
        [<Emit("$0($1)")>]
        abstract invoke: reactElement:ReactElement * ?options:IRenderOptions -> Render

    let renderImport : RenderImport = import "render" "@testing-library/react"

    type queriesForElement (queryApi: QueriesForElement) =
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByLabelText (matcher: string, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.getByLabelText(!^matcher, options)
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByLabelText (matcher: Regex, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.getByLabelText(!^matcher, options)
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByLabelText (matcher: string * HTMLElement -> bool, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.getByLabelText(!^matcher, options)
        
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByLabelText (matcher: string, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.getAllByLabelText(!^matcher, options)
            |> List.ofSeq
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByLabelText (matcher: Regex, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.getAllByLabelText(!^matcher, options)
            |> List.ofSeq
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByLabelText (matcher: string * HTMLElement -> bool, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.getAllByLabelText(!^matcher, options)
            |> List.ofSeq
        
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByLabelText (matcher: string, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.queryByLabelText(!^matcher, options)
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByLabelText (matcher: Regex, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.queryByLabelText(!^matcher, options)
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByLabelText (matcher: string * HTMLElement -> bool, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.queryByLabelText(!^matcher, options)
        
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByLabelText (matcher: string, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.queryAllByLabelText(!^matcher, options)
            |> List.ofSeq
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByLabelText (matcher: Regex, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.queryAllByLabelText(!^matcher, options)
            |> List.ofSeq
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByLabelText (matcher: string * HTMLElement -> bool, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.queryAllByLabelText(!^matcher, options)
            |> List.ofSeq
        
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByLabelText (matcher: string, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.findByLabelText(!^matcher, options)
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByLabelText (matcher: Regex, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.findByLabelText(!^matcher, options)
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByLabelText (matcher: string * HTMLElement -> bool, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.findByLabelText(!^matcher, options)
        
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByLabelText (matcher: string, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.findAllByLabelText(!^matcher, options)
            |> Promise.map List.ofSeq
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByLabelText (matcher: Regex, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.findAllByLabelText(!^matcher, options)
            |> Promise.map List.ofSeq
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByLabelText (matcher: string * HTMLElement -> bool, ?selector : string, ?exact: bool, ?normalizer: string -> string) = 
            LabelTextMatcher.create selector exact normalizer
            |> fun options -> queryApi.findAllByLabelText(!^matcher, options)
            |> Promise.map List.ofSeq
            
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByPlaceholderText (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getByPlaceholderText(!^matcher, options)
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByPlaceholderText (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getByPlaceholderText(!^matcher, options)
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByPlaceholderText (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getByPlaceholderText(!^matcher, options)
            
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByPlaceholderText (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getAllByPlaceholderText(!^matcher, options)
            |> List.ofSeq
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByPlaceholderText (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getAllByPlaceholderText(!^matcher, options)
            |> List.ofSeq
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByPlaceholderText (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getAllByPlaceholderText(!^matcher, options)
            |> List.ofSeq
            
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByPlaceholderText (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryByPlaceholderText(!^matcher, options)
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByPlaceholderText (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryByPlaceholderText(!^matcher, options)
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByPlaceholderText (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryByPlaceholderText(!^matcher, options)
            
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByPlaceholderText (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryAllByPlaceholderText(!^matcher, options)
            |> List.ofSeq
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByPlaceholderText (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryAllByPlaceholderText(!^matcher, options)
            |> List.ofSeq
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByPlaceholderText (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryAllByPlaceholderText(!^matcher, options)
            |> List.ofSeq
        
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByPlaceholderText (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findByPlaceholderText(!^matcher, options)
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByPlaceholderText (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findByPlaceholderText(!^matcher, options)
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByPlaceholderText (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findByPlaceholderText(!^matcher, options)
        
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByPlaceholderText (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findAllByPlaceholderText(!^matcher, options)
            |> Promise.map List.ofSeq
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByPlaceholderText (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findAllByPlaceholderText(!^matcher, options)
            |> Promise.map List.ofSeq
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByPlaceholderText (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findAllByPlaceholderText(!^matcher, options)
            |> Promise.map List.ofSeq
            
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByText (matcher: string, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.getByText(!^matcher, options)
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByText (matcher: Regex, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.getByText(!^matcher, options)
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByText (matcher: string * HTMLElement -> bool, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.getByText(!^matcher, options)
        
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByText (matcher: string, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.getAllByText(!^matcher, options)
            |> List.ofSeq
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByText (matcher: Regex, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.getAllByText(!^matcher, options)
            |> List.ofSeq
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByText (matcher: string * HTMLElement -> bool, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.getAllByText(!^matcher, options)
            |> List.ofSeq
        
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByText (matcher: string, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.queryByText(!^matcher, options)
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByText (matcher: Regex, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.queryByText(!^matcher, options)
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByText (matcher: string * HTMLElement -> bool, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.queryByText(!^matcher, options)
        
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByText (matcher: string, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.queryAllByText(!^matcher, options)
            |> List.ofSeq
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByText (matcher: Regex, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.queryAllByText(!^matcher, options)
            |> List.ofSeq
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByText (matcher: string * HTMLElement -> bool, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.queryAllByText(!^matcher, options)
            |> List.ofSeq
        
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByText (matcher: string, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.findByText(!^matcher, options)
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByText (matcher: Regex, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.findByText(!^matcher, options)
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByText (matcher: string * HTMLElement -> bool, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.findByText(!^matcher, options)
        
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByText (matcher: string, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.findAllByText(!^matcher, options)
            |> Promise.map List.ofSeq
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByText (matcher: Regex, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.findAllByText(!^matcher, options)
            |> Promise.map List.ofSeq
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByText (matcher: string * HTMLElement -> bool, ?selector : string, ?ignore: string, ?exact: bool, ?normalizer: string -> string) = 
            TextMatcher.create selector (ignore |> Option.map (!^)) exact normalizer
            |> fun options -> queryApi.findAllByText(!^matcher, options)
            |> Promise.map List.ofSeq
            
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByTitle (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getByTitle(!^matcher, options)
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByTitle (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getByTitle(!^matcher, options)
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByTitle (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getByTitle(!^matcher, options)
        
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByTitle (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getAllByTitle(!^matcher, options)
            |> List.ofSeq
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByTitle (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getAllByTitle(!^matcher, options)
            |> List.ofSeq
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByTitle (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getAllByTitle(!^matcher, options)
            |> List.ofSeq
        
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByTitle (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryByTitle(!^matcher, options)
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByTitle (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryByTitle(!^matcher, options)
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByTitle (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryByTitle(!^matcher, options)
        
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByTitle (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryAllByTitle(!^matcher, options)
            |> List.ofSeq
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByTitle (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryAllByTitle(!^matcher, options)
            |> List.ofSeq
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByTitle (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryAllByTitle(!^matcher, options)
            |> List.ofSeq
        
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByTitle (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findByTitle(!^matcher, options)
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByTitle (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findByTitle(!^matcher, options)
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByTitle (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findByTitle(!^matcher, options)
        
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByTitle (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findAllByTitle(!^matcher, options)
            |> Promise.map List.ofSeq
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByTitle (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findAllByTitle(!^matcher, options)
            |> Promise.map List.ofSeq
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByTitle (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findAllByTitle(!^matcher, options)
            |> Promise.map List.ofSeq
        
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByDisplayValue (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getByDisplayValue(!^matcher, options)
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByDisplayValue (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getByDisplayValue(!^matcher, options)
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByDisplayValue (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getByDisplayValue(!^matcher, options)
        
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByDisplayValue (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getAllByDisplayValue(!^matcher, options)
            |> List.ofSeq
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByDisplayValue (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getAllByDisplayValue(!^matcher, options)
            |> List.ofSeq
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByDisplayValue (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getAllByDisplayValue(!^matcher, options)
            |> List.ofSeq
        
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByDisplayValue (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryByDisplayValue(!^matcher, options)
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByDisplayValue (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryByDisplayValue(!^matcher, options)
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByDisplayValue (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryByDisplayValue(!^matcher, options)
        
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByDisplayValue (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryAllByDisplayValue(!^matcher, options)
            |> List.ofSeq
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByDisplayValue (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryAllByDisplayValue(!^matcher, options)
            |> List.ofSeq
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByDisplayValue (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryAllByDisplayValue(!^matcher, options)
            |> List.ofSeq
        
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByDisplayValue (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findByDisplayValue(!^matcher, options)
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByDisplayValue (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findByDisplayValue(!^matcher, options)
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByDisplayValue (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findByDisplayValue(!^matcher, options)
        
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByDisplayValue (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findAllByDisplayValue(!^matcher, options)
            |> Promise.map List.ofSeq
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByDisplayValue (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findAllByDisplayValue(!^matcher, options)
            |> Promise.map List.ofSeq
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByDisplayValue (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findAllByDisplayValue(!^matcher, options)
            |> Promise.map List.ofSeq
            
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByRole (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getByRole(!^matcher, options)
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByRole (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getByRole(!^matcher, options)
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByRole (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getByRole(!^matcher, options)
        
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByRole (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getAllByRole(!^matcher, options)
            |> List.ofSeq
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByRole (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getAllByRole(!^matcher, options)
            |> List.ofSeq
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByRole (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getAllByRole(!^matcher, options)
            |> List.ofSeq
        
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByRole (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryByRole(!^matcher, options)
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByRole (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryByRole(!^matcher, options)
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByRole (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryByRole(!^matcher, options)
        
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByRole (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryAllByRole(!^matcher, options)
            |> List.ofSeq
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByRole (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryAllByRole(!^matcher, options)
            |> List.ofSeq
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByRole (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryAllByRole(!^matcher, options)
            |> List.ofSeq
        
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByRole (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findByRole(!^matcher, options)
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByRole (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findByRole(!^matcher, options)
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByRole (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findByRole(!^matcher, options)
        
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByRole (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findAllByRole(!^matcher, options)
            |> Promise.map List.ofSeq
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByRole (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findAllByRole(!^matcher, options)
            |> Promise.map List.ofSeq
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByRole (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findAllByRole(!^matcher, options)
            |> Promise.map List.ofSeq
            
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByTestId (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getByTestId(!^matcher, options)
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByTestId (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getByTestId(!^matcher, options)
        /// getBy* queries return the first matching node for a query, and throw an error if no elements match or if more than 
        /// one match is found (use getAllBy instead).
        member _.getByTestId (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getByTestId(!^matcher, options)
        
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByTestId (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getAllByTestId(!^matcher, options)
            |> List.ofSeq
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByTestId (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getAllByTestId(!^matcher, options)
            |> List.ofSeq
        /// getAllBy* queries return a list of all matching nodes for a query, and throw an error if no elements match.
        member _.getAllByTestId (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.getAllByTestId(!^matcher, options)
            |> List.ofSeq
        
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByTestId (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryByTestId(!^matcher, options)
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByTestId (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryByTestId(!^matcher, options)
        /// queryBy* queries return the first matching node for a query, and return null if no elements match. This is useful for asserting an element that is not present. 
        /// This throws if more than one match is found (use queryAllBy instead).
        member _.queryByTestId (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryByTestId(!^matcher, options)
        
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByTestId (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryAllByTestId(!^matcher, options)
            |> List.ofSeq
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByTestId (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryAllByTestId(!^matcher, options)
            |> List.ofSeq
        /// queryAllBy* queries return a list of all matching nodes for a query, and return an empty list if no elements match.
        member _.queryAllByTestId (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.queryAllByTestId(!^matcher, options)
            |> List.ofSeq
        
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByTestId (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findByTestId(!^matcher, options)
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByTestId (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findByTestId(!^matcher, options)
        /// findBy* queries return a promise which resolves when an element is found which matches the given query. 
        /// The promise is rejected if no element is found or if more than one element is found after a default timeout of 4500ms. 
        /// If you need to find more than one element, then use findAllBy.
        member _.findByTestId (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findByTestId(!^matcher, options)
        
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByTestId (matcher: string, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findAllByTestId(!^matcher, options)
            |> Promise.map List.ofSeq
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByTestId (matcher: Regex, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findAllByTestId(!^matcher, options)
            |> Promise.map List.ofSeq
        /// findAllBy* queries return a promise which resolves to an array of elements when any elements are found which match the given query. 
        /// The promise is rejected if no elements are found after a default timeout of 4500ms.
        member _.findAllByTestId (matcher: string * HTMLElement -> bool, ?exact: bool, ?normalizer: string -> string) = 
            MatcherOptions.create exact normalizer
            |> fun options -> queryApi.findAllByTestId(!^matcher, options)
            |> Promise.map List.ofSeq
        
    type render (render: Render) =
        inherit queriesForElement(render)

        /// The containing DOM node where your React Element is rendered in the container. 
        /// If you don't specify the baseElement in the options of render, it will default to document.body.
        ///
        /// This is useful when the component you want to test renders something outside the container div, e.g. 
        /// when you want to snapshot test your portal component which renders its HTML directly in the body.
        member _.baseElement = render.baseElement
        /// The containing DOM node of your rendered React Element (rendered using ReactDOM.render). 
        /// It's a div. This is a regular DOM node, so you can call container.querySelector etc. to inspect the children.
        member _.container = render.container
        /// Returns a DocumentFragment of your rendered component. This can be useful if you need to avoid live bindings 
        /// and see how your component reacts to events.
        member _.asFragment () = render.asFragment()
        /// This method is a shortcut for console.log(prettyDOM(baseElement))
        member _.debug () = render.debug()
        /// It'd probably be better if you test the component that's doing the prop updating to ensure that the props are being 
        /// updated correctly (see the Guiding Principles section). That said, if you'd prefer to update the props of a rendered 
        /// component in your test, this function can be used to update props of the rendered component.
        member _.rerender (reactElement: ReactElement) = render.rerender reactElement
        /// This will cause the rendered component to be unmounted. This is useful for testing what happens when your component 
        /// is removed from the page (like testing that you don't leave event handlers hanging around causing memory leaks).
        member _.unmount () = render.unmount()
    
    type WaitFor =
        [<Emit("$0($1)")>]
        abstract invoke: callback: (unit -> 'T) * ?options: IWaitOptions -> JS.Promise<'T>

    let waitForImport : WaitFor = import "waitFor" "@testing-library/react"

    type WaitForElementToBeRemoved =
        abstract invoke: callback: (unit -> 'T) * ?options: IWaitOptions -> JS.Promise<'T>

    let waitForElementToBeRemovedImport : WaitForElementToBeRemoved = import "waitForElementToBeRemoved" "@testing-library/react"

    type Within =
        [<Emit("$0($1)")>]
        abstract invoke: node:HTMLElement -> QueriesForElement

    let withinImport : Within = import "within" "@testing-library/react"
