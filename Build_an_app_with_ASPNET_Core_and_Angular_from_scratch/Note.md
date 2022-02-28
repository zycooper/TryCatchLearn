### Questions need to search
#### C# Attribute
#### List vs IEnumerable
#### C# Serialization
#### API return json format(camel case instead of capital case)
#### .Net 6 changes api structure

#### Angular: OnInit is lifecycle hook which happens after the constructor
#### add cors  must be after userouting and before endpoints and authorization in api

#### Authentication
Hashing the password - not a good way/not enough<br>
Hashing and salt the password


#### ASP.NET Identity
#### DTO - Data Transfer Object - Why?

#### c# method signature
>Methods are declared in a class, struct, or interface by specifying the access level such as public or private, optional modifiers such as abstract or sealed, the return value, the name of the method, and any method parameters. These parts together are the signature of the method.

#### authentication vs authorization

#### JSON Web Token

testing is the main reason for creating an interface. (when place an interface along with the funciton that impleament it in the DI container in startup.cs)<br>

#### observable(RxJS) vs promise (map/pipe)

#### double exclamation !! in angular

#### asyncpipe

#### Angular services are singleton

#### toast service ngx-toastr

#### when [boject object]

#### local company: neighbour Match

#### ng-container is a good way to wrap some items in when you use conditional code like ngif, because it doesn't create any actual html item

#### bootswatch

#### the sequence inside angular.json->styles matters

#### we cannot secure an app only front client side(route or guard), we have to do something on the back-end

#### API middleware -> APIException && ExceptionMiddleware

#### RequestDelegate Ilogger<>

#### ActionResult

#### RequestDelegate

#### C# single question mark vs double question marks

#### const, same scope like let, but cannot change once it bonds

#### Eorror Interceptor

#### javascript 2019(ES) flat function of array

#### can only access the state through constructor, not the OnInit

#### Repository Pattern

#### eager loating vs lazy loading

#### DTO to solve avoid nested objects

#### AutoMapper

#### JSON to TS -> convert sample json file to a TS interface declaration

#### interceptor is a component of antular in default

#### (<form #editForm>) editForm.dirty is boolean when a form component has been touched
#### this.editform.rest(this.member);

#### angular uses the name property to track the property in form, the name is case sensitive

#### Guard: CanActivate(CanActivateChild), CanDeactivate and CanLoad

#### Angular of function: pretent you are using a http(subscribe) instead of a instant array || of -> return something of observable

#### Angular: pipe take 1

#### Rxjs -> take(1) vs first() https://stackoverflow.com/questions/42345969/take1-vs-first

#### services are singleton -> so you can save data(state in services)

#### dollar sign(eg. member$) -> indicate that this variable is an Observable https://angular.io/guide/rx-library#naming-conventions-for-observables

#### Upload photo -> create an service class take care of the photo physical storation then return id along with name,url etc then wrap this info into a photo class then attach it to the user object

#### ng2-file-upload
#### ngx-spinner

### (ng)UI-Component -> (ng)Service -> (API)Controller -> (API)_repository/_context
#### Reactive Froms vs Template_Driven Forms
##### https://www.pluralsight.com/guides/difference-between-template-driven-and-reactive-forms-angular
##### https://blog.angular-university.io/introduction-to-angular-2-forms-template-driven-vs-model-driven/
##### https://i.stack.imgur.com/HZQlS.png

#### use FormBuilder servise then group all formControls into it

#### angular CoreModule vs SharedModule https://thetombomb.com/posts/app-core-shared-feature-modules

#### ControlValueAccessor is used to create re-used components

#### C# IQueryable vs IEnumerable

#### switch after orderby

#### IAsyncActionFilter

#### Lost: action filter

#### because it's an angular bootstrap component or module, we'll need to use forRoot()
#### Above: when to use Angular's forRoot() method https://medium.com/slackernoon/when-to-use-angulars-forroot-method-400094a0ebb7

#### memberCache = new Map(); --> in Angular --> map is an RxJS operator

#### three dots -> spread operator in js/ts
-create a copy of a object
-destruct an array and pass them to parameters
-avoid same definition

#### Save filters -> save it in the service since service is singleton(but after refresh the page it will reset)

#### why DI in web api/mvc

### Adding the messaging feature

### [FromQuery]
url smaple : controller/{username} -> url/lisa?roles=admin,member
controller function 
func example_func(string username, [FromQuery]roles)
{
    //roles == admin,member
}

### getDecodedToken
atob(token.split('.'[1]))

### jwt
header | payload | signature

### || -> or
user.KnownAs || user.username -> if knownas is null, just username

### SignalR
Http is a protocal and web socket is also a protocol
signalR will choose the best way among web socket, server-send event or long-polling
signalR or web socket cannot send request with authentication header

### baseUrl
under environments folder, the environment.ts could store the qas base url and prd url

### dictionary in .net is not thread secure
if multiple users are trying to read/write the same static dictionary simultaneously, it could wrong into problem. Solution -> use lock

### thread safe