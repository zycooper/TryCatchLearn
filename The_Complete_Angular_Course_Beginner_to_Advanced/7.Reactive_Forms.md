## Reactive Forms


Used to dynamically create form(s)

-----
### Building a Bootstrap Form

-----
### Creating Controls Programmatically
![image](https://user-images.githubusercontent.com/26094307/105864876-fd676e00-5fb7-11eb-8009-8107687098e8.png)
![image](https://user-images.githubusercontent.com/26094307/105865354-79fa4c80-5fb8-11eb-9968-ca0de9bab860.png)
![image](https://user-images.githubusercontent.com/26094307/105865486-9a2a0b80-5fb8-11eb-96c5-3230b9dbdae6.png)
![image](https://user-images.githubusercontent.com/26094307/105865548-a9a95480-5fb8-11eb-86b6-e2461591c9fe.png)

-----
### Adding Validation
when using reactive form, we don't use html attribute, so below will be deleted. We assign validators when create form control object dynamically in the ts file
![image](https://user-images.githubusercontent.com/26094307/105869558-fa22b100-5fbc-11eb-9a27-2f7de40f07b7.png)

![image](https://user-images.githubusercontent.com/26094307/105869612-060e7300-5fbd-11eb-9387-773c9d740e8f.png)
to this
![image](https://user-images.githubusercontent.com/26094307/106091964-090b7f80-60f3-11eb-860f-34f6aa9e188a.png)

-----
### Specific Validation Errors
Multiple validators
![image](https://user-images.githubusercontent.com/26094307/106092332-ab2b6780-60f3-11eb-9445-7210ca0caf35.png)

![image](https://user-images.githubusercontent.com/26094307/106092406-dada6f80-60f3-11eb-9a60-171369b851bf.png)

-----
### Implementing Custom Validation
different components may use the same customer validator, so if you have several validators, place them into one folder and make them static
![image](https://user-images.githubusercontent.com/26094307/106093572-21c96480-60f6-11eb-9db1-1acdf96de259.png)

call the customer validator
![image](https://user-images.githubusercontent.com/26094307/106093425-e29b1380-60f5-11eb-8854-498217526906.png)
customer validator itself
![image](https://user-images.githubusercontent.com/26094307/106093466-f9416a80-60f5-11eb-9fa9-ce0c7218e5a9.png)
in the template
![image](https://user-images.githubusercontent.com/26094307/106093620-3d346f80-60f6-11eb-89df-3dc25203a7bd.png)

-----
### Asynchronous Operations

-----
### Asynchronous Validators

-----
### Showing a Loader Image

-----
### Validating the Form Input Upon Submit

-----
### Nested FormGroups

-----
### FormArray

-----
### FormBuilder
