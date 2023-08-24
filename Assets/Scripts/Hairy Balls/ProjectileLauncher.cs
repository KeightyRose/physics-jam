using UnityEngine;
using UnityEngine.UI;

public class ProjectileLauncher : MonoBehaviour
{
    public Rigidbody projectilePrefab;
    public Transform spawnPoint;
    public Slider gravitySlider;
    public Slider forceSlider;
    public Slider massSlider;
    public Slider velocitySlider;
    public Text infoText;

    private Rigidbody currentProjectile;

    private void Start()
    {
        UpdateInfoText();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Change to your input method
        {
            LaunchProjectile();
        }
    }

    public void LaunchProjectile()
    {
        if (currentProjectile)
        {
            Destroy(currentProjectile.gameObject);
        }

        currentProjectile = Instantiate(projectilePrefab, spawnPoint.position, Quaternion.identity);
        float force = forceSlider.value;
        float mass = massSlider.value;
        float velocity = velocitySlider.value;
        Vector3 launchDirection = spawnPoint.forward * velocity;

        currentProjectile.mass = mass;
        currentProjectile.AddForce(launchDirection * force, ForceMode.Impulse);
    }

    public void UpdateInfoText()
    {
        string info = $"Gravity: {gravitySlider.value:F2}\nForce: {forceSlider.value:F2}\nMass: {massSlider.value:F2}\nVelocity: {velocitySlider.value:F2}";
        infoText.text = info;
    }

    public void OnGravitySliderChanged()
    {
        Physics.gravity = new Vector3(0, -gravitySlider.value, 0);
        UpdateInfoText();
    }

    public void OnForceSliderChanged()
    {
        UpdateInfoText();
    }

    public void OnMassSliderChanged()
    {
        UpdateInfoText();
    }

    public void OnVelocitySliderChanged()
    {
        UpdateInfoText();
    }
}
