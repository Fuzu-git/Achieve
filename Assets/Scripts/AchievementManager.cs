using System;
using UnityEngine;
using UnityEngine.UI; 

public class AchievementManager : MonoBehaviour
{
    private bool _once;
    private bool _onceAgain;
    public int has3Achievement = 0;
    private int AchievementNumber = 0;

    public GameObject changingText;
    
    public static Action AchievementsMark; 
    
    private void Start()
    {
        CharacterController.MoveForward += delegate
        {
            Debug.Log("Congratulation for walking straight forward. :)");
            has3Achievement++;
            AchievementNumber++;
        };

        CharacterController.MoveBackward += delegate
        {
            Debug.Log("Congratulation for walking straight backward. :)");
            has3Achievement++;
            AchievementNumber++;
        };

        CharacterController.MoveLeft += delegate
        {
            Debug.Log("Congratulation for walking straight to the left. :)");
            has3Achievement++;
            AchievementNumber++;
        };

        CharacterController.MoveRight += delegate
        {
            Debug.Log("Congratulation for walking straight to the right. :)");
            has3Achievement++;
            AchievementNumber++;
        };

        Respawn.playerRespawned += delegate
        {
            Debug.Log("Ok, try not to die again.");
            has3Achievement++;
            AchievementNumber++;
        };


        fire.playerHasShot += delegate
        {
            Debug.Log("Congrats for shooting");
            has3Achievement++;
            AchievementNumber++;
        };

        bullet.bulletHasHit += delegate
        {
            if (!_once)
            {
                Debug.Log("Congrats for shooting on something");
                _once = true;
                has3Achievement++;
                AchievementNumber++;
            }
        };

        AchievementsMark += delegate
        {
            if (has3Achievement == 4 && !_onceAgain)
            {
                Debug.Log("Congrats for Finishing the game");
                _onceAgain = true; 
                AchievementNumber++;
            }
        };
    }

    private void Update()
    {
        AchievementsMark?.Invoke();
        
        TextChange();
    }
    
    public void TextChange()
    {
        changingText.GetComponent<Text>().text = AchievementNumber + "/8";
    }
}
